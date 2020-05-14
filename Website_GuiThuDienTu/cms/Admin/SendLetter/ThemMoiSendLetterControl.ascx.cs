using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website_GuiThuDienTu.cms.Admin.SendLetter
{
    public partial class ThemMoiSendLetterControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstbEmail.Items.Clear();
                if (Session["iPK_MaCD"].ToString() != null)
                {
                    int iPK_MaCD = int.Parse(Session["iPK_MaCD"].ToString()) + 1;
                    DataTable table = new DataTable();
                    table = App_Data.ChuDe.HienChiTietChuDe(iPK_MaCD);
                    if (table.Rows.Count > 0)
                    {
                        txtSubject.Text = table.Rows[0]["sTenCD"].ToString();
                    }
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        lstbEmail.Items.Add(table.Rows[i]["sEmail"].ToString());
                    }
                }
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string _from = Session["sEmail"].ToString();
            string _password = Session["sPassword"].ToString();
            //string[] _to = new string[lstbEmail.Items.Count];
            //for (int i = 0; i < lstbEmail.Items.Count; i++)
            //{
            //    _to[i] = lstbEmail.Items[i].ToString();
            //}
            string _cc = txtCC.Text.Trim();
            string _bcc = txtBCC.Text.Trim();
            string _subject = txtSubject.Text.Trim();
            string _body = txtBody.Text.Trim();

            MailMessage tMailMessage = new MailMessage();
            tMailMessage.From = new MailAddress(_from);

            foreach (ListItem item in lstbEmail.Items)
            {
                if (item.Selected)
                {
                    tMailMessage.To.Add(item.ToString());
                }
            }

            if (_cc != null && _cc != "")
            {
                tMailMessage.CC.Add(new MailAddress(_cc));
            }
            if (_bcc != null && _bcc != "")
            {
                tMailMessage.Bcc.Add(new MailAddress(_bcc));
            }
            tMailMessage.Subject = _subject;
            tMailMessage.Body = _body;
            if (flAttachment.HasFile)
            {
                HttpFileCollection fc = Request.Files;
                for (int i = 1; i < fc.Count; i++)
                {
                    HttpPostedFile pf = fc[i];
                    Attachment attach = new Attachment(pf.InputStream, pf.FileName);
                    tMailMessage.Attachments.Add(attach);
                }
            }
            tMailMessage.IsBodyHtml = true;
            tMailMessage.Priority = MailPriority.Normal;
            tMailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            tMailMessage.BodyEncoding = System.Text.Encoding.UTF8;

            SmtpClient tSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            tSmtpClient.EnableSsl = true;
            tSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            tSmtpClient.UseDefaultCredentials = false;
            tSmtpClient.Credentials = new System.Net.NetworkCredential(_from, _password);
            tSmtpClient.Send(tMailMessage);

            //SendMailMessage(_from, _to, _cc, _bcc, _subject, _body, _password);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "message", "alert('Gửi thư thành công')", true);
        }

        private void SendMailMessage(string from, string[] to, string cc, string bcc, string subject, string body, string password)
        {
            MailMessage tMailMessage = new MailMessage();
            tMailMessage.From = new MailAddress(from);
            foreach (string MultiEmail in to)
            {
                tMailMessage.To.Add(new MailAddress(MultiEmail));
            }
            if (cc != null && cc != "")
            {
                tMailMessage.CC.Add(new MailAddress(cc));
            }
            if (bcc != null && bcc != "")
            {
                tMailMessage.Bcc.Add(new MailAddress(bcc));
            }
            tMailMessage.Subject = subject;
            tMailMessage.Body = body;
            tMailMessage.IsBodyHtml = true;
            tMailMessage.Priority = MailPriority.Normal;
            tMailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            tMailMessage.BodyEncoding = System.Text.Encoding.UTF8;

            SmtpClient tSmtpClient = new SmtpClient("smtp.gmail.com", 587);
            tSmtpClient.EnableSsl = true;
            tSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            tSmtpClient.UseDefaultCredentials = false;
            tSmtpClient.Credentials = new System.Net.NetworkCredential(from, password);
            tSmtpClient.Send(tMailMessage);
        }



    }
}