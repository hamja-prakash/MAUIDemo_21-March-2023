﻿using MAUISampleDemo.View;
using MAUISampleDemo.View.CsharpMarkup;
using MAUISampleDemo.View.Database;
using MAUISampleDemo.View.FieldModifier;
using MAUISampleDemo.View.LazyView;
using MAUISampleDemo.View.Stepper;
using MAUISampleDemo.View.Validations;
using MAUISampleDemo.ViewModels;
using Mopups.Services;

namespace MAUISampleDemo;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel mainPageViewModel)
    {
		InitializeComponent();
        CommonToolbar.LblToolbarTitle.Text = "Main Page";
        CommonToolbar.ImgToolbarBack.IsVisible = false;
        this.BindingContext = mainPageViewModel;
    }

    #region [ Events ]
    private void FrmMVVMDemo_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMVVMDemo, new HomePage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmDeviceandAPPInfo_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmDevice_APPInfo, new Device_APPInfoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmFiledModifiers_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmFiledModifiers, new FieldModifierMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmObservableProperty_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmObservableProperty, new ObservablePropertyDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmScanner_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmScanner, new View.BarcodeScannerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmLocalization_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmLocalization, new LocalizationDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCardView_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCardView, new CardViewDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmChangeStatusbarBG_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmChangeStatusBarBG, new ChangeStatusbarBGPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmFilePicker_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmFilePicker, new FilePickerPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCachedImage_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCachedImage, new CacheImagePage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmLocalNtf_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmLocalNtf, new LocalNotificationPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMetroLog_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMetroLog, new MetroLogDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmRefreshEmpty_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmRefreshEmpty, new RefreshandEmpltyViewDemoPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmImagecolorchange_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmImagecolorchange, new ImagechangecolorDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMAUIPagewithSharpMrkp_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMAUIPagewithSharpMrkp, new CsharpMarkupMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMVVMDatabinding_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMVVMDatabinding, new MVVM_Databinding());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmLottieAnimation_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmLottieAnimation, new LottieAnimationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomCalender_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomCalender, new CustomCalender());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmAudio_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmAudio, new AudioDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBarcodeGenerate_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmBarcodeGenerate, new BarcodeGenerateDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCompileBinding_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCompileBinding, new ComplieBindingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmImgUpload_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmImgUpload, new ImageUploadDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCollectionviewGrouping_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCollectionviewGrouping, new CollectionViewGroupingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomizeCntwithHndlr_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomizeCntwithHndlr, new CustomiseControlwithHandlerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMAUIStyle_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMAUIStyle, new MAUIStyleDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmDBEncrypted_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmDBEncrypted, new CRUDoperationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmScheduleListUI_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmScheduleListUI, new ScheduleListUIDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmAnimatedMenu_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmAnimatedMenu, new PlanetsPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMAUISouceGenerator_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMAUISouceGenerator, new MVVMSourceGeneratorDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMAUIPlatformSpc_Tapped(object sender, EventArgs e)
    {
        try
        {
            NavigationPage(FrmMAUIPlatformSpc, new PlatformSpecificCodeDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMAUIAnimation_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmMAUIAnimation, new AnimationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmNullCoalescing_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmNullCoalescing, new NullCoalescingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmRating_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmRating, new RatingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmValidation_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmValidation, new DifferentValidationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmclvinsideScr_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmclvinsideScr, new CollectionviewinsideScrollviewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmAutoSizeEditor_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmAutoSizeEditor, new AutoSizeEditorDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCstLogin_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCstLogin, new CustomizeLoginPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmResponsiveLyt_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmResponsiveLyt, new ResponsiveLayoutPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmStateContainer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmStateContainer, new StateContainerViewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmSemanticOrderView_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmSemanticOrderView, new SemanticOrderViewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMopup_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            MopupService.Instance.PushAsync(new MAUIPopupPageDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMusicPlay_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmMusicPlay, new MusicPlayDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBLE_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBLE, new BlutoothScanningDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomUI_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomUI, new CustomUI());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBMICalculation_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBMICalculation, new BMICalculationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
    private void FrmBottomsheet_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBottomsheet, new BottomSheetMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmExpandableprgh_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmExpandableprgh, new ExpandableParagraphDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCnvWithPrm_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCnvWithPrm, new ConverterwithMultiPrmDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmShareContact_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmShareContact, new ContactShareDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmImagewithGraphics_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmImagewithGraphics, new ImagewithGraphics());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCameraView_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCameraView, new CameraViewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmEmailSMSPhoneDialer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmEmailSMSPhoneDialer, new Email_SMS_PhoneDialerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomControl_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomControl, new CustomControlDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmDragandDrop_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmDragandDrop, new DragandDropDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBtnWithProgressbar_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBtnWithProgressbar, new ButtonControlWithProgressBarDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmEmailAuth_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmEmailAuth, new EmailAuthDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmPagination_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmPagination, new PaginationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmFlAcBtn_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmFlAcBtn, new FloatingActionButtonDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomPicker_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomPicker, new CustomPickerControlDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmWebview_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmWebview, new WebviewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmExpColClvGrp_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmExpColClvGrp, new ExpandandCollapseClvGroupDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmLazyView_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmLazyView, new LazyViewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBarcodeScnviaGoogleVision_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBarcodeScnviaGoogleVision, new BarcodeScannerwithGoogleVisionDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMultiLocalization_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmMultiLocalization, new MultiLanguageLocalizationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmContextandMenuAcninlst_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmContextandMenuAcninlst, new ContextandMenuActioninListView());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmSkeletonEffect_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmSkeletonEffect, new SkeletonEffectDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmShowHideKeyboard_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmShowHideKeyboard, new Show_Hide_KeyboardDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCstUIwithKyb_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCstUIwithKyb, new CustomizeUIwithKeyboard());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmStepper_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmStepper, new StepperDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmDrawingView_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmDrawingView, new DrawingViewDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmFFImage_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmFFImage, new FFImageDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomImgBrd_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomImgBrd, new CustomImageborderDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    [Obsolete]
    private void FrmEventWithTimer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmEventWithTimer, new EventwithTimerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmValidationRules_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmValidationRules, new ValidationMainPage());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmSignUpUI_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmSignUpUI, new SignUpUIDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void Frmdatagrid_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(Frmdatagrid, new DataGridDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmScreenSecurity_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmScreenSecurity, new ScreenSecurityDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmBasicAnimation_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmBasicAnimation, new BasicAnimationDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmCustomizeTitlebar_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmCustomizeTitlebar, new CustomizeTitleBarDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmProgressbar_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmProgressbar, new ProgressBarDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmMultiTarget_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmMultiTarget, new MultiTargetingDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmPrgwithTimer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmPrgwithTimer, new ProgressbarwithTimerDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    //private async void FrmBiometricsAuth_Tapped(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        await FrmBiometricsAuth.ScaleTo(0.9, 100, Easing.Linear);
    //        await FrmBiometricsAuth.ScaleTo(1.0, 100, Easing.Linear);
    //        IFingerprint fingerprint = CrossFingerprint.Current;
    //        //typeof(IFingerprint) = CrossFingerprint.Current;
    //        BiometricsAuthViewModel viewModel = new BiometricsAuthViewModel(fingerprint);
    //        await Navigation.PushAsync(new BiometricsAuthDemo(viewModel));
    //    }
    //    catch (Exception ex)
    //    {
    //        var err = ex.Message;
    //    }
    //} 
    #endregion

    #region [ Methods ]
    public async void NavigationPage(Frame frame, Page page)
    {
        try
        {
            await frame.ScaleTo(0.9, 100, Easing.Linear);
            await frame.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(page);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    #endregion

    
}

