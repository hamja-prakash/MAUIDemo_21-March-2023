namespace MAUISampleDemo.View;

public partial class Email_SMS_PhoneDialerDemo : ContentPage
{
	public Email_SMS_PhoneDialerDemo()
	{
		InitializeComponent();
	}

    private void btnPhoneDial_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (PhoneDialer.Default.IsSupported)
                PhoneDialer.Default.Open("7043762490");
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void btnsms_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (Sms.Default.IsComposeSupported)
            {
                string[] recipients = new[] { "809-555-5454" };
                string text = "Hi everyone, I'm a MAUI SMS!";
                var message = new SmsMessage(text, recipients);
                await Sms.Default.ComposeAsync(message);
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void btnEmail_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (Email.Default.IsComposeSupported)
            {
                var message = new EmailMessage
                {
                    Subject = "Hi how are you?",
                    Body = "Thanks for being here, nice to meet you!",
                    BodyFormat = EmailBodyFormat.PlainText,
                    To = new List<string>(new[] { "marie@outlook.com", "jose@outlook.com", "peter@outlook.com" })
                };
                //message.Attachments.Add(new EmailAttachment(Path.Combine(FileSystem.CacheDirectory, "dotnet_bot.svg")));
                await Email.Default.ComposeAsync(message);
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}