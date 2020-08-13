using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// V 1.0.0 - 2020-07-14 09:13:34
/// 首次创建 
/// 
/// FontAwesome 工具类
/// 
/// FontAwesomeModel
/// 用于 XAML 页面中展示所有 Icon 信息
/// 
/// FontAwesomeIcons
/// 用户 XAML 编码中的自动提示
/// </summary>
namespace Util_Font
{
    public class FontAwesomeModel
    {
        public static List<FontAwesomeModel> GetAllList()
        {
            List<FontAwesomeModel> r = new List<FontAwesomeModel>();

            // 采用 FontAwesome 5 Pro 分两种 普通 与 商标
            r.Add(new FontAwesomeModel() { Name = "Abacus", Code = "\uf640", Code_XML = "&#xf640" });
            r.Add(new FontAwesomeModel() { Name = "AccessibleIcon", Code = "\uf368", Code_XML = "&#xf368" });
            r.Add(new FontAwesomeModel() { Name = "Accusoft", Code = "\uf369", Code_XML = "&#xf369" });
            r.Add(new FontAwesomeModel() { Name = "Acorn", Code = "\uf6ae", Code_XML = "&#xf6ae" });
            r.Add(new FontAwesomeModel() { Name = "AcquisitionsIncorporated", Code = "\uf6af", Code_XML = "&#xf6af" });
            r.Add(new FontAwesomeModel() { Name = "Ad", Code = "\uf641", Code_XML = "&#xf641" });
            r.Add(new FontAwesomeModel() { Name = "AddressBook", Code = "\uf2b9", Code_XML = "&#xf2b9" });
            r.Add(new FontAwesomeModel() { Name = "AddressCard", Code = "\uf2bb", Code_XML = "&#xf2bb" });
            r.Add(new FontAwesomeModel() { Name = "Adjust", Code = "\uf042", Code_XML = "&#xf042" });
            r.Add(new FontAwesomeModel() { Name = "Adn", Code = "\uf170", Code_XML = "&#xf170" });
            r.Add(new FontAwesomeModel() { Name = "Adversal", Code = "\uf36a", Code_XML = "&#xf36a" });
            r.Add(new FontAwesomeModel() { Name = "Affiliatetheme", Code = "\uf36b", Code_XML = "&#xf36b" });
            r.Add(new FontAwesomeModel() { Name = "AirFreshener", Code = "\uf5d0", Code_XML = "&#xf5d0" });
            r.Add(new FontAwesomeModel() { Name = "AlarmClock", Code = "\uf34e", Code_XML = "&#xf34e" });
            r.Add(new FontAwesomeModel() { Name = "Algolia", Code = "\uf36c", Code_XML = "&#xf36c" });
            r.Add(new FontAwesomeModel() { Name = "Alicorn", Code = "\uf6b0", Code_XML = "&#xf6b0" });
            r.Add(new FontAwesomeModel() { Name = "AlignCenter", Code = "\uf037", Code_XML = "&#xf037" });
            r.Add(new FontAwesomeModel() { Name = "AlignJustify", Code = "\uf039", Code_XML = "&#xf039" });
            r.Add(new FontAwesomeModel() { Name = "AlignLeft", Code = "\uf036", Code_XML = "&#xf036" });
            r.Add(new FontAwesomeModel() { Name = "AlignRight", Code = "\uf038", Code_XML = "&#xf038" });
            r.Add(new FontAwesomeModel() { Name = "Alipay", Code = "\uf642", Code_XML = "&#xf642" });
            r.Add(new FontAwesomeModel() { Name = "Allergies", Code = "\uf461", Code_XML = "&#xf461" });
            r.Add(new FontAwesomeModel() { Name = "Amazon", Code = "\uf270", Code_XML = "&#xf270" });
            r.Add(new FontAwesomeModel() { Name = "AmazonPay", Code = "\uf42c", Code_XML = "&#xf42c" });
            r.Add(new FontAwesomeModel() { Name = "Ambulance", Code = "\uf0f9", Code_XML = "&#xf0f9" });
            r.Add(new FontAwesomeModel() { Name = "AmericanSignLanguageInterpreting", Code = "\uf2a3", Code_XML = "&#xf2a3" });
            r.Add(new FontAwesomeModel() { Name = "Amilia", Code = "\uf36d", Code_XML = "&#xf36d" });
            r.Add(new FontAwesomeModel() { Name = "Analytics", Code = "\uf643", Code_XML = "&#xf643" });
            r.Add(new FontAwesomeModel() { Name = "Anchor", Code = "\uf13d", Code_XML = "&#xf13d" });
            r.Add(new FontAwesomeModel() { Name = "Android", Code = "\uf17b", Code_XML = "&#xf17b" });
            r.Add(new FontAwesomeModel() { Name = "Angellist", Code = "\uf209", Code_XML = "&#xf209" });
            r.Add(new FontAwesomeModel() { Name = "AngleDoubleDown", Code = "\uf103", Code_XML = "&#xf103" });
            r.Add(new FontAwesomeModel() { Name = "AngleDoubleLeft", Code = "\uf100", Code_XML = "&#xf100" });
            r.Add(new FontAwesomeModel() { Name = "AngleDoubleRight", Code = "\uf101", Code_XML = "&#xf101" });
            r.Add(new FontAwesomeModel() { Name = "AngleDoubleUp", Code = "\uf102", Code_XML = "&#xf102" });
            r.Add(new FontAwesomeModel() { Name = "AngleDown", Code = "\uf107", Code_XML = "&#xf107" });
            r.Add(new FontAwesomeModel() { Name = "AngleLeft", Code = "\uf104", Code_XML = "&#xf104" });
            r.Add(new FontAwesomeModel() { Name = "AngleRight", Code = "\uf105", Code_XML = "&#xf105" });
            r.Add(new FontAwesomeModel() { Name = "AngleUp", Code = "\uf106", Code_XML = "&#xf106" });
            r.Add(new FontAwesomeModel() { Name = "Angry", Code = "\uf556", Code_XML = "&#xf556" });
            r.Add(new FontAwesomeModel() { Name = "Angrycreative", Code = "\uf36e", Code_XML = "&#xf36e" });
            r.Add(new FontAwesomeModel() { Name = "Angular", Code = "\uf420", Code_XML = "&#xf420" });
            r.Add(new FontAwesomeModel() { Name = "Ankh", Code = "\uf644", Code_XML = "&#xf644" });
            r.Add(new FontAwesomeModel() { Name = "AppStore", Code = "\uf36f", Code_XML = "&#xf36f" });
            r.Add(new FontAwesomeModel() { Name = "AppStoreIos", Code = "\uf370", Code_XML = "&#xf370" });
            r.Add(new FontAwesomeModel() { Name = "Apper", Code = "\uf371", Code_XML = "&#xf371" });
            r.Add(new FontAwesomeModel() { Name = "Apple", Code = "\uf179", Code_XML = "&#xf179" });
            r.Add(new FontAwesomeModel() { Name = "AppleAlt", Code = "\uf5d1", Code_XML = "&#xf5d1" });
            r.Add(new FontAwesomeModel() { Name = "AppleCrate", Code = "\uf6b1", Code_XML = "&#xf6b1" });
            r.Add(new FontAwesomeModel() { Name = "ApplePay", Code = "\uf415", Code_XML = "&#xf415" });
            r.Add(new FontAwesomeModel() { Name = "Archive", Code = "\uf187", Code_XML = "&#xf187" });
            r.Add(new FontAwesomeModel() { Name = "Archway", Code = "\uf557", Code_XML = "&#xf557" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltCircleDown", Code = "\uf358", Code_XML = "&#xf358" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltCircleLeft", Code = "\uf359", Code_XML = "&#xf359" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltCircleRight", Code = "\uf35a", Code_XML = "&#xf35a" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltCircleUp", Code = "\uf35b", Code_XML = "&#xf35b" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltDown", Code = "\uf354", Code_XML = "&#xf354" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltFromBottom", Code = "\uf346", Code_XML = "&#xf346" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltFromLeft", Code = "\uf347", Code_XML = "&#xf347" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltFromRight", Code = "\uf348", Code_XML = "&#xf348" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltFromTop", Code = "\uf349", Code_XML = "&#xf349" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltLeft", Code = "\uf355", Code_XML = "&#xf355" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltRight", Code = "\uf356", Code_XML = "&#xf356" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltSquareDown", Code = "\uf350", Code_XML = "&#xf350" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltSquareLeft", Code = "\uf351", Code_XML = "&#xf351" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltSquareRight", Code = "\uf352", Code_XML = "&#xf352" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltSquareUp", Code = "\uf353", Code_XML = "&#xf353" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltToBottom", Code = "\uf34a", Code_XML = "&#xf34a" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltToLeft", Code = "\uf34b", Code_XML = "&#xf34b" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltToRight", Code = "\uf34c", Code_XML = "&#xf34c" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltToTop", Code = "\uf34d", Code_XML = "&#xf34d" });
            r.Add(new FontAwesomeModel() { Name = "ArrowAltUp", Code = "\uf357", Code_XML = "&#xf357" });
            r.Add(new FontAwesomeModel() { Name = "ArrowCircleDown", Code = "\uf0ab", Code_XML = "&#xf0ab" });
            r.Add(new FontAwesomeModel() { Name = "ArrowCircleLeft", Code = "\uf0a8", Code_XML = "&#xf0a8" });
            r.Add(new FontAwesomeModel() { Name = "ArrowCircleRight", Code = "\uf0a9", Code_XML = "&#xf0a9" });
            r.Add(new FontAwesomeModel() { Name = "ArrowCircleUp", Code = "\uf0aa", Code_XML = "&#xf0aa" });
            r.Add(new FontAwesomeModel() { Name = "ArrowDown", Code = "\uf063", Code_XML = "&#xf063" });
            r.Add(new FontAwesomeModel() { Name = "ArrowFromBottom", Code = "\uf342", Code_XML = "&#xf342" });
            r.Add(new FontAwesomeModel() { Name = "ArrowFromLeft", Code = "\uf343", Code_XML = "&#xf343" });
            r.Add(new FontAwesomeModel() { Name = "ArrowFromRight", Code = "\uf344", Code_XML = "&#xf344" });
            r.Add(new FontAwesomeModel() { Name = "ArrowFromTop", Code = "\uf345", Code_XML = "&#xf345" });
            r.Add(new FontAwesomeModel() { Name = "ArrowLeft", Code = "\uf060", Code_XML = "&#xf060" });
            r.Add(new FontAwesomeModel() { Name = "ArrowRight", Code = "\uf061", Code_XML = "&#xf061" });
            r.Add(new FontAwesomeModel() { Name = "ArrowSquareDown", Code = "\uf339", Code_XML = "&#xf339" });
            r.Add(new FontAwesomeModel() { Name = "ArrowSquareLeft", Code = "\uf33a", Code_XML = "&#xf33a" });
            r.Add(new FontAwesomeModel() { Name = "ArrowSquareRight", Code = "\uf33b", Code_XML = "&#xf33b" });
            r.Add(new FontAwesomeModel() { Name = "ArrowSquareUp", Code = "\uf33c", Code_XML = "&#xf33c" });
            r.Add(new FontAwesomeModel() { Name = "ArrowToBottom", Code = "\uf33d", Code_XML = "&#xf33d" });
            r.Add(new FontAwesomeModel() { Name = "ArrowToLeft", Code = "\uf33e", Code_XML = "&#xf33e" });
            r.Add(new FontAwesomeModel() { Name = "ArrowToRight", Code = "\uf340", Code_XML = "&#xf340" });
            r.Add(new FontAwesomeModel() { Name = "ArrowToTop", Code = "\uf341", Code_XML = "&#xf341" });
            r.Add(new FontAwesomeModel() { Name = "ArrowUp", Code = "\uf062", Code_XML = "&#xf062" });
            r.Add(new FontAwesomeModel() { Name = "Arrows", Code = "\uf047", Code_XML = "&#xf047" });
            r.Add(new FontAwesomeModel() { Name = "ArrowsAlt", Code = "\uf0b2", Code_XML = "&#xf0b2" });
            r.Add(new FontAwesomeModel() { Name = "ArrowsAltH", Code = "\uf337", Code_XML = "&#xf337" });
            r.Add(new FontAwesomeModel() { Name = "ArrowsAltV", Code = "\uf338", Code_XML = "&#xf338" });
            r.Add(new FontAwesomeModel() { Name = "ArrowsH", Code = "\uf07e", Code_XML = "&#xf07e" });
            r.Add(new FontAwesomeModel() { Name = "ArrowsV", Code = "\uf07d", Code_XML = "&#xf07d" });
            r.Add(new FontAwesomeModel() { Name = "AssistiveListeningSystems", Code = "\uf2a2", Code_XML = "&#xf2a2" });
            r.Add(new FontAwesomeModel() { Name = "Asterisk", Code = "\uf069", Code_XML = "&#xf069" });
            r.Add(new FontAwesomeModel() { Name = "Asymmetrik", Code = "\uf372", Code_XML = "&#xf372" });
            r.Add(new FontAwesomeModel() { Name = "At", Code = "\uf1fa", Code_XML = "&#xf1fa" });
            r.Add(new FontAwesomeModel() { Name = "Atlas", Code = "\uf558", Code_XML = "&#xf558" });
            r.Add(new FontAwesomeModel() { Name = "Atom", Code = "\uf5d2", Code_XML = "&#xf5d2" });
            r.Add(new FontAwesomeModel() { Name = "AtomAlt", Code = "\uf5d3", Code_XML = "&#xf5d3" });
            r.Add(new FontAwesomeModel() { Name = "Audible", Code = "\uf373", Code_XML = "&#xf373" });
            r.Add(new FontAwesomeModel() { Name = "AudioDescription", Code = "\uf29e", Code_XML = "&#xf29e" });
            r.Add(new FontAwesomeModel() { Name = "Autoprefixer", Code = "\uf41c", Code_XML = "&#xf41c" });
            r.Add(new FontAwesomeModel() { Name = "Avianex", Code = "\uf374", Code_XML = "&#xf374" });
            r.Add(new FontAwesomeModel() { Name = "Aviato", Code = "\uf421", Code_XML = "&#xf421" });
            r.Add(new FontAwesomeModel() { Name = "Award", Code = "\uf559", Code_XML = "&#xf559" });
            r.Add(new FontAwesomeModel() { Name = "Aws", Code = "\uf375", Code_XML = "&#xf375" });
            r.Add(new FontAwesomeModel() { Name = "Axe", Code = "\uf6b2", Code_XML = "&#xf6b2" });
            r.Add(new FontAwesomeModel() { Name = "AxeBattle", Code = "\uf6b3", Code_XML = "&#xf6b3" });
            r.Add(new FontAwesomeModel() { Name = "Backpack", Code = "\uf5d4", Code_XML = "&#xf5d4" });
            r.Add(new FontAwesomeModel() { Name = "Backspace", Code = "\uf55a", Code_XML = "&#xf55a" });
            r.Add(new FontAwesomeModel() { Name = "Backward", Code = "\uf04a", Code_XML = "&#xf04a" });
            r.Add(new FontAwesomeModel() { Name = "Badge", Code = "\uf335", Code_XML = "&#xf335" });
            r.Add(new FontAwesomeModel() { Name = "BadgeCheck", Code = "\uf336", Code_XML = "&#xf336" });
            r.Add(new FontAwesomeModel() { Name = "BadgeDollar", Code = "\uf645", Code_XML = "&#xf645" });
            r.Add(new FontAwesomeModel() { Name = "BadgePercent", Code = "\uf646", Code_XML = "&#xf646" });
            r.Add(new FontAwesomeModel() { Name = "BadgerHoney", Code = "\uf6b4", Code_XML = "&#xf6b4" });
            r.Add(new FontAwesomeModel() { Name = "BalanceScale", Code = "\uf24e", Code_XML = "&#xf24e" });
            r.Add(new FontAwesomeModel() { Name = "BalanceScaleLeft", Code = "\uf515", Code_XML = "&#xf515" });
            r.Add(new FontAwesomeModel() { Name = "BalanceScaleRight", Code = "\uf516", Code_XML = "&#xf516" });
            r.Add(new FontAwesomeModel() { Name = "Ballot", Code = "\uf732", Code_XML = "&#xf732" });
            r.Add(new FontAwesomeModel() { Name = "BallotCheck", Code = "\uf733", Code_XML = "&#xf733" });
            r.Add(new FontAwesomeModel() { Name = "Ban", Code = "\uf05e", Code_XML = "&#xf05e" });
            r.Add(new FontAwesomeModel() { Name = "BandAid", Code = "\uf462", Code_XML = "&#xf462" });
            r.Add(new FontAwesomeModel() { Name = "Bandcamp", Code = "\uf2d5", Code_XML = "&#xf2d5" });
            r.Add(new FontAwesomeModel() { Name = "Barcode", Code = "\uf02a", Code_XML = "&#xf02a" });
            r.Add(new FontAwesomeModel() { Name = "BarcodeAlt", Code = "\uf463", Code_XML = "&#xf463" });
            r.Add(new FontAwesomeModel() { Name = "BarcodeRead", Code = "\uf464", Code_XML = "&#xf464" });
            r.Add(new FontAwesomeModel() { Name = "BarcodeScan", Code = "\uf465", Code_XML = "&#xf465" });
            r.Add(new FontAwesomeModel() { Name = "Bars", Code = "\uf0c9", Code_XML = "&#xf0c9" });
            r.Add(new FontAwesomeModel() { Name = "Baseball", Code = "\uf432", Code_XML = "&#xf432" });
            r.Add(new FontAwesomeModel() { Name = "BaseballBall", Code = "\uf433", Code_XML = "&#xf433" });
            r.Add(new FontAwesomeModel() { Name = "BasketballBall", Code = "\uf434", Code_XML = "&#xf434" });
            r.Add(new FontAwesomeModel() { Name = "BasketballHoop", Code = "\uf435", Code_XML = "&#xf435" });
            r.Add(new FontAwesomeModel() { Name = "Bat", Code = "\uf6b5", Code_XML = "&#xf6b5" });
            r.Add(new FontAwesomeModel() { Name = "Bath", Code = "\uf2cd", Code_XML = "&#xf2cd" });
            r.Add(new FontAwesomeModel() { Name = "BatteryBolt", Code = "\uf376", Code_XML = "&#xf376" });
            r.Add(new FontAwesomeModel() { Name = "BatteryEmpty", Code = "\uf244", Code_XML = "&#xf244" });
            r.Add(new FontAwesomeModel() { Name = "BatteryFull", Code = "\uf240", Code_XML = "&#xf240" });
            r.Add(new FontAwesomeModel() { Name = "BatteryHalf", Code = "\uf242", Code_XML = "&#xf242" });
            r.Add(new FontAwesomeModel() { Name = "BatteryQuarter", Code = "\uf243", Code_XML = "&#xf243" });
            r.Add(new FontAwesomeModel() { Name = "BatterySlash", Code = "\uf377", Code_XML = "&#xf377" });
            r.Add(new FontAwesomeModel() { Name = "BatteryThreeQuarters", Code = "\uf241", Code_XML = "&#xf241" });
            r.Add(new FontAwesomeModel() { Name = "Bed", Code = "\uf236", Code_XML = "&#xf236" });
            r.Add(new FontAwesomeModel() { Name = "Beer", Code = "\uf0fc", Code_XML = "&#xf0fc" });
            r.Add(new FontAwesomeModel() { Name = "Behance", Code = "\uf1b4", Code_XML = "&#xf1b4" });
            r.Add(new FontAwesomeModel() { Name = "BehanceSquare", Code = "\uf1b5", Code_XML = "&#xf1b5" });
            r.Add(new FontAwesomeModel() { Name = "Bell", Code = "\uf0f3", Code_XML = "&#xf0f3" });
            r.Add(new FontAwesomeModel() { Name = "BellSchool", Code = "\uf5d5", Code_XML = "&#xf5d5" });
            r.Add(new FontAwesomeModel() { Name = "BellSchoolSlash", Code = "\uf5d6", Code_XML = "&#xf5d6" });
            r.Add(new FontAwesomeModel() { Name = "BellSlash", Code = "\uf1f6", Code_XML = "&#xf1f6" });
            r.Add(new FontAwesomeModel() { Name = "BezierCurve", Code = "\uf55b", Code_XML = "&#xf55b" });
            r.Add(new FontAwesomeModel() { Name = "Bible", Code = "\uf647", Code_XML = "&#xf647" });
            r.Add(new FontAwesomeModel() { Name = "Bicycle", Code = "\uf206", Code_XML = "&#xf206" });
            r.Add(new FontAwesomeModel() { Name = "Bimobject", Code = "\uf378", Code_XML = "&#xf378" });
            r.Add(new FontAwesomeModel() { Name = "Binoculars", Code = "\uf1e5", Code_XML = "&#xf1e5" });
            r.Add(new FontAwesomeModel() { Name = "BirthdayCake", Code = "\uf1fd", Code_XML = "&#xf1fd" });
            r.Add(new FontAwesomeModel() { Name = "Bitbucket", Code = "\uf171", Code_XML = "&#xf171" });
            r.Add(new FontAwesomeModel() { Name = "Bitcoin", Code = "\uf379", Code_XML = "&#xf379" });
            r.Add(new FontAwesomeModel() { Name = "Bity", Code = "\uf37a", Code_XML = "&#xf37a" });
            r.Add(new FontAwesomeModel() { Name = "BlackTie", Code = "\uf27e", Code_XML = "&#xf27e" });
            r.Add(new FontAwesomeModel() { Name = "Blackberry", Code = "\uf37b", Code_XML = "&#xf37b" });
            r.Add(new FontAwesomeModel() { Name = "Blanket", Code = "\uf498", Code_XML = "&#xf498" });
            r.Add(new FontAwesomeModel() { Name = "Blender", Code = "\uf517", Code_XML = "&#xf517" });
            r.Add(new FontAwesomeModel() { Name = "BlenderPhone", Code = "\uf6b6", Code_XML = "&#xf6b6" });
            r.Add(new FontAwesomeModel() { Name = "Blind", Code = "\uf29d", Code_XML = "&#xf29d" });
            r.Add(new FontAwesomeModel() { Name = "Blogger", Code = "\uf37c", Code_XML = "&#xf37c" });
            r.Add(new FontAwesomeModel() { Name = "BloggerB", Code = "\uf37d", Code_XML = "&#xf37d" });
            r.Add(new FontAwesomeModel() { Name = "Bluetooth", Code = "\uf293", Code_XML = "&#xf293" });
            r.Add(new FontAwesomeModel() { Name = "BluetoothB", Code = "\uf294", Code_XML = "&#xf294" });
            r.Add(new FontAwesomeModel() { Name = "Bold", Code = "\uf032", Code_XML = "&#xf032" });
            r.Add(new FontAwesomeModel() { Name = "Bolt", Code = "\uf0e7", Code_XML = "&#xf0e7" });
            r.Add(new FontAwesomeModel() { Name = "Bomb", Code = "\uf1e2", Code_XML = "&#xf1e2" });
            r.Add(new FontAwesomeModel() { Name = "Bone", Code = "\uf5d7", Code_XML = "&#xf5d7" });
            r.Add(new FontAwesomeModel() { Name = "BoneBreak", Code = "\uf5d8", Code_XML = "&#xf5d8" });
            r.Add(new FontAwesomeModel() { Name = "Bong", Code = "\uf55c", Code_XML = "&#xf55c" });
            r.Add(new FontAwesomeModel() { Name = "Book", Code = "\uf02d", Code_XML = "&#xf02d" });
            r.Add(new FontAwesomeModel() { Name = "BookAlt", Code = "\uf5d9", Code_XML = "&#xf5d9" });
            r.Add(new FontAwesomeModel() { Name = "BookDead", Code = "\uf6b7", Code_XML = "&#xf6b7" });
            r.Add(new FontAwesomeModel() { Name = "BookHeart", Code = "\uf499", Code_XML = "&#xf499" });
            r.Add(new FontAwesomeModel() { Name = "BookOpen", Code = "\uf518", Code_XML = "&#xf518" });
            r.Add(new FontAwesomeModel() { Name = "BookReader", Code = "\uf5da", Code_XML = "&#xf5da" });
            r.Add(new FontAwesomeModel() { Name = "BookSpells", Code = "\uf6b8", Code_XML = "&#xf6b8" });
            r.Add(new FontAwesomeModel() { Name = "Bookmark", Code = "\uf02e", Code_XML = "&#xf02e" });
            r.Add(new FontAwesomeModel() { Name = "Books", Code = "\uf5db", Code_XML = "&#xf5db" });
            r.Add(new FontAwesomeModel() { Name = "BoothCurtain", Code = "\uf734", Code_XML = "&#xf734" });
            r.Add(new FontAwesomeModel() { Name = "BowArrow", Code = "\uf6b9", Code_XML = "&#xf6b9" });
            r.Add(new FontAwesomeModel() { Name = "BowlingBall", Code = "\uf436", Code_XML = "&#xf436" });
            r.Add(new FontAwesomeModel() { Name = "BowlingPins", Code = "\uf437", Code_XML = "&#xf437" });
            r.Add(new FontAwesomeModel() { Name = "Box", Code = "\uf466", Code_XML = "&#xf466" });
            r.Add(new FontAwesomeModel() { Name = "BoxAlt", Code = "\uf49a", Code_XML = "&#xf49a" });
            r.Add(new FontAwesomeModel() { Name = "BoxBallot", Code = "\uf735", Code_XML = "&#xf735" });
            r.Add(new FontAwesomeModel() { Name = "BoxCheck", Code = "\uf467", Code_XML = "&#xf467" });
            r.Add(new FontAwesomeModel() { Name = "BoxFragile", Code = "\uf49b", Code_XML = "&#xf49b" });
            r.Add(new FontAwesomeModel() { Name = "BoxFull", Code = "\uf49c", Code_XML = "&#xf49c" });
            r.Add(new FontAwesomeModel() { Name = "BoxHeart", Code = "\uf49d", Code_XML = "&#xf49d" });
            r.Add(new FontAwesomeModel() { Name = "BoxOpen", Code = "\uf49e", Code_XML = "&#xf49e" });
            r.Add(new FontAwesomeModel() { Name = "BoxUp", Code = "\uf49f", Code_XML = "&#xf49f" });
            r.Add(new FontAwesomeModel() { Name = "BoxUsd", Code = "\uf4a0", Code_XML = "&#xf4a0" });
            r.Add(new FontAwesomeModel() { Name = "Boxes", Code = "\uf468", Code_XML = "&#xf468" });
            r.Add(new FontAwesomeModel() { Name = "BoxesAlt", Code = "\uf4a1", Code_XML = "&#xf4a1" });
            r.Add(new FontAwesomeModel() { Name = "BoxingGlove", Code = "\uf438", Code_XML = "&#xf438" });
            r.Add(new FontAwesomeModel() { Name = "Braille", Code = "\uf2a1", Code_XML = "&#xf2a1" });
            r.Add(new FontAwesomeModel() { Name = "Brain", Code = "\uf5dc", Code_XML = "&#xf5dc" });
            r.Add(new FontAwesomeModel() { Name = "Briefcase", Code = "\uf0b1", Code_XML = "&#xf0b1" });
            r.Add(new FontAwesomeModel() { Name = "BriefcaseMedical", Code = "\uf469", Code_XML = "&#xf469" });
            r.Add(new FontAwesomeModel() { Name = "BroadcastTower", Code = "\uf519", Code_XML = "&#xf519" });
            r.Add(new FontAwesomeModel() { Name = "Broom", Code = "\uf51a", Code_XML = "&#xf51a" });
            r.Add(new FontAwesomeModel() { Name = "Browser", Code = "\uf37e", Code_XML = "&#xf37e" });
            r.Add(new FontAwesomeModel() { Name = "Brush", Code = "\uf55d", Code_XML = "&#xf55d" });
            r.Add(new FontAwesomeModel() { Name = "Btc", Code = "\uf15a", Code_XML = "&#xf15a" });
            r.Add(new FontAwesomeModel() { Name = "Bug", Code = "\uf188", Code_XML = "&#xf188" });
            r.Add(new FontAwesomeModel() { Name = "Building", Code = "\uf1ad", Code_XML = "&#xf1ad" });
            r.Add(new FontAwesomeModel() { Name = "Bullhorn", Code = "\uf0a1", Code_XML = "&#xf0a1" });
            r.Add(new FontAwesomeModel() { Name = "Bullseye", Code = "\uf140", Code_XML = "&#xf140" });
            r.Add(new FontAwesomeModel() { Name = "BullseyeArrow", Code = "\uf648", Code_XML = "&#xf648" });
            r.Add(new FontAwesomeModel() { Name = "BullseyePointer", Code = "\uf649", Code_XML = "&#xf649" });
            r.Add(new FontAwesomeModel() { Name = "Burn", Code = "\uf46a", Code_XML = "&#xf46a" });
            r.Add(new FontAwesomeModel() { Name = "Buromobelexperte", Code = "\uf37f", Code_XML = "&#xf37f" });
            r.Add(new FontAwesomeModel() { Name = "Bus", Code = "\uf207", Code_XML = "&#xf207" });
            r.Add(new FontAwesomeModel() { Name = "BusAlt", Code = "\uf55e", Code_XML = "&#xf55e" });
            r.Add(new FontAwesomeModel() { Name = "BusSchool", Code = "\uf5dd", Code_XML = "&#xf5dd" });
            r.Add(new FontAwesomeModel() { Name = "BusinessTime", Code = "\uf64a", Code_XML = "&#xf64a" });
            r.Add(new FontAwesomeModel() { Name = "Buysellads", Code = "\uf20d", Code_XML = "&#xf20d" });
            r.Add(new FontAwesomeModel() { Name = "CabinetFiling", Code = "\uf64b", Code_XML = "&#xf64b" });
            r.Add(new FontAwesomeModel() { Name = "Calculator", Code = "\uf1ec", Code_XML = "&#xf1ec" });
            r.Add(new FontAwesomeModel() { Name = "CalculatorAlt", Code = "\uf64c", Code_XML = "&#xf64c" });
            r.Add(new FontAwesomeModel() { Name = "Calendar", Code = "\uf133", Code_XML = "&#xf133" });
            r.Add(new FontAwesomeModel() { Name = "CalendarAlt", Code = "\uf073", Code_XML = "&#xf073" });
            r.Add(new FontAwesomeModel() { Name = "CalendarCheck", Code = "\uf274", Code_XML = "&#xf274" });
            r.Add(new FontAwesomeModel() { Name = "CalendarEdit", Code = "\uf333", Code_XML = "&#xf333" });
            r.Add(new FontAwesomeModel() { Name = "CalendarExclamation", Code = "\uf334", Code_XML = "&#xf334" });
            r.Add(new FontAwesomeModel() { Name = "CalendarMinus", Code = "\uf272", Code_XML = "&#xf272" });
            r.Add(new FontAwesomeModel() { Name = "CalendarPlus", Code = "\uf271", Code_XML = "&#xf271" });
            r.Add(new FontAwesomeModel() { Name = "CalendarStar", Code = "\uf736", Code_XML = "&#xf736" });
            r.Add(new FontAwesomeModel() { Name = "CalendarTimes", Code = "\uf273", Code_XML = "&#xf273" });
            r.Add(new FontAwesomeModel() { Name = "Camera", Code = "\uf030", Code_XML = "&#xf030" });
            r.Add(new FontAwesomeModel() { Name = "CameraAlt", Code = "\uf332", Code_XML = "&#xf332" });
            r.Add(new FontAwesomeModel() { Name = "CameraRetro", Code = "\uf083", Code_XML = "&#xf083" });
            r.Add(new FontAwesomeModel() { Name = "Campfire", Code = "\uf6ba", Code_XML = "&#xf6ba" });
            r.Add(new FontAwesomeModel() { Name = "Campground", Code = "\uf6bb", Code_XML = "&#xf6bb" });
            r.Add(new FontAwesomeModel() { Name = "CandleHolder", Code = "\uf6bc", Code_XML = "&#xf6bc" });
            r.Add(new FontAwesomeModel() { Name = "CandyCorn", Code = "\uf6bd", Code_XML = "&#xf6bd" });
            r.Add(new FontAwesomeModel() { Name = "Cannabis", Code = "\uf55f", Code_XML = "&#xf55f" });
            r.Add(new FontAwesomeModel() { Name = "Capsules", Code = "\uf46b", Code_XML = "&#xf46b" });
            r.Add(new FontAwesomeModel() { Name = "Car", Code = "\uf1b9", Code_XML = "&#xf1b9" });
            r.Add(new FontAwesomeModel() { Name = "CarAlt", Code = "\uf5de", Code_XML = "&#xf5de" });
            r.Add(new FontAwesomeModel() { Name = "CarBattery", Code = "\uf5df", Code_XML = "&#xf5df" });
            r.Add(new FontAwesomeModel() { Name = "CarBump", Code = "\uf5e0", Code_XML = "&#xf5e0" });
            r.Add(new FontAwesomeModel() { Name = "CarCrash", Code = "\uf5e1", Code_XML = "&#xf5e1" });
            r.Add(new FontAwesomeModel() { Name = "CarGarage", Code = "\uf5e2", Code_XML = "&#xf5e2" });
            r.Add(new FontAwesomeModel() { Name = "CarMechanic", Code = "\uf5e3", Code_XML = "&#xf5e3" });
            r.Add(new FontAwesomeModel() { Name = "CarSide", Code = "\uf5e4", Code_XML = "&#xf5e4" });
            r.Add(new FontAwesomeModel() { Name = "CarTilt", Code = "\uf5e5", Code_XML = "&#xf5e5" });
            r.Add(new FontAwesomeModel() { Name = "CarWash", Code = "\uf5e6", Code_XML = "&#xf5e6" });
            r.Add(new FontAwesomeModel() { Name = "CaretCircleDown", Code = "\uf32d", Code_XML = "&#xf32d" });
            r.Add(new FontAwesomeModel() { Name = "CaretCircleLeft", Code = "\uf32e", Code_XML = "&#xf32e" });
            r.Add(new FontAwesomeModel() { Name = "CaretCircleRight", Code = "\uf330", Code_XML = "&#xf330" });
            r.Add(new FontAwesomeModel() { Name = "CaretCircleUp", Code = "\uf331", Code_XML = "&#xf331" });
            r.Add(new FontAwesomeModel() { Name = "CaretDown", Code = "\uf0d7", Code_XML = "&#xf0d7" });
            r.Add(new FontAwesomeModel() { Name = "CaretLeft", Code = "\uf0d9", Code_XML = "&#xf0d9" });
            r.Add(new FontAwesomeModel() { Name = "CaretRight", Code = "\uf0da", Code_XML = "&#xf0da" });
            r.Add(new FontAwesomeModel() { Name = "CaretSquareDown", Code = "\uf150", Code_XML = "&#xf150" });
            r.Add(new FontAwesomeModel() { Name = "CaretSquareLeft", Code = "\uf191", Code_XML = "&#xf191" });
            r.Add(new FontAwesomeModel() { Name = "CaretSquareRight", Code = "\uf152", Code_XML = "&#xf152" });
            r.Add(new FontAwesomeModel() { Name = "CaretSquareUp", Code = "\uf151", Code_XML = "&#xf151" });
            r.Add(new FontAwesomeModel() { Name = "CaretUp", Code = "\uf0d8", Code_XML = "&#xf0d8" });
            r.Add(new FontAwesomeModel() { Name = "CartArrowDown", Code = "\uf218", Code_XML = "&#xf218" });
            r.Add(new FontAwesomeModel() { Name = "CartPlus", Code = "\uf217", Code_XML = "&#xf217" });
            r.Add(new FontAwesomeModel() { Name = "Cat", Code = "\uf6be", Code_XML = "&#xf6be" });
            r.Add(new FontAwesomeModel() { Name = "Cauldron", Code = "\uf6bf", Code_XML = "&#xf6bf" });
            r.Add(new FontAwesomeModel() { Name = "CcAmazonPay", Code = "\uf42d", Code_XML = "&#xf42d" });
            r.Add(new FontAwesomeModel() { Name = "CcAmex", Code = "\uf1f3", Code_XML = "&#xf1f3" });
            r.Add(new FontAwesomeModel() { Name = "CcApplePay", Code = "\uf416", Code_XML = "&#xf416" });
            r.Add(new FontAwesomeModel() { Name = "CcDinersClub", Code = "\uf24c", Code_XML = "&#xf24c" });
            r.Add(new FontAwesomeModel() { Name = "CcDiscover", Code = "\uf1f2", Code_XML = "&#xf1f2" });
            r.Add(new FontAwesomeModel() { Name = "CcJcb", Code = "\uf24b", Code_XML = "&#xf24b" });
            r.Add(new FontAwesomeModel() { Name = "CcMastercard", Code = "\uf1f1", Code_XML = "&#xf1f1" });
            r.Add(new FontAwesomeModel() { Name = "CcPaypal", Code = "\uf1f4", Code_XML = "&#xf1f4" });
            r.Add(new FontAwesomeModel() { Name = "CcStripe", Code = "\uf1f5", Code_XML = "&#xf1f5" });
            r.Add(new FontAwesomeModel() { Name = "CcVisa", Code = "\uf1f0", Code_XML = "&#xf1f0" });
            r.Add(new FontAwesomeModel() { Name = "Centercode", Code = "\uf380", Code_XML = "&#xf380" });
            r.Add(new FontAwesomeModel() { Name = "Certificate", Code = "\uf0a3", Code_XML = "&#xf0a3" });
            r.Add(new FontAwesomeModel() { Name = "Chair", Code = "\uf6c0", Code_XML = "&#xf6c0" });
            r.Add(new FontAwesomeModel() { Name = "ChairOffice", Code = "\uf6c1", Code_XML = "&#xf6c1" });
            r.Add(new FontAwesomeModel() { Name = "Chalkboard", Code = "\uf51b", Code_XML = "&#xf51b" });
            r.Add(new FontAwesomeModel() { Name = "ChalkboardTeacher", Code = "\uf51c", Code_XML = "&#xf51c" });
            r.Add(new FontAwesomeModel() { Name = "ChargingStation", Code = "\uf5e7", Code_XML = "&#xf5e7" });
            r.Add(new FontAwesomeModel() { Name = "ChartArea", Code = "\uf1fe", Code_XML = "&#xf1fe" });
            r.Add(new FontAwesomeModel() { Name = "ChartBar", Code = "\uf080", Code_XML = "&#xf080" });
            r.Add(new FontAwesomeModel() { Name = "ChartLine", Code = "\uf201", Code_XML = "&#xf201" });
            r.Add(new FontAwesomeModel() { Name = "ChartLineDown", Code = "\uf64d", Code_XML = "&#xf64d" });
            r.Add(new FontAwesomeModel() { Name = "ChartPie", Code = "\uf200", Code_XML = "&#xf200" });
            r.Add(new FontAwesomeModel() { Name = "ChartPieAlt", Code = "\uf64e", Code_XML = "&#xf64e" });
            r.Add(new FontAwesomeModel() { Name = "Check", Code = "\uf00c", Code_XML = "&#xf00c" });
            r.Add(new FontAwesomeModel() { Name = "CheckCircle", Code = "\uf058", Code_XML = "&#xf058" });
            r.Add(new FontAwesomeModel() { Name = "CheckDouble", Code = "\uf560", Code_XML = "&#xf560" });
            r.Add(new FontAwesomeModel() { Name = "CheckSquare", Code = "\uf14a", Code_XML = "&#xf14a" });
            r.Add(new FontAwesomeModel() { Name = "Chess", Code = "\uf439", Code_XML = "&#xf439" });
            r.Add(new FontAwesomeModel() { Name = "ChessBishop", Code = "\uf43a", Code_XML = "&#xf43a" });
            r.Add(new FontAwesomeModel() { Name = "ChessBishopAlt", Code = "\uf43b", Code_XML = "&#xf43b" });
            r.Add(new FontAwesomeModel() { Name = "ChessBoard", Code = "\uf43c", Code_XML = "&#xf43c" });
            r.Add(new FontAwesomeModel() { Name = "ChessClock", Code = "\uf43d", Code_XML = "&#xf43d" });
            r.Add(new FontAwesomeModel() { Name = "ChessClockAlt", Code = "\uf43e", Code_XML = "&#xf43e" });
            r.Add(new FontAwesomeModel() { Name = "ChessKing", Code = "\uf43f", Code_XML = "&#xf43f" });
            r.Add(new FontAwesomeModel() { Name = "ChessKingAlt", Code = "\uf440", Code_XML = "&#xf440" });
            r.Add(new FontAwesomeModel() { Name = "ChessKnight", Code = "\uf441", Code_XML = "&#xf441" });
            r.Add(new FontAwesomeModel() { Name = "ChessKnightAlt", Code = "\uf442", Code_XML = "&#xf442" });
            r.Add(new FontAwesomeModel() { Name = "ChessPawn", Code = "\uf443", Code_XML = "&#xf443" });
            r.Add(new FontAwesomeModel() { Name = "ChessPawnAlt", Code = "\uf444", Code_XML = "&#xf444" });
            r.Add(new FontAwesomeModel() { Name = "ChessQueen", Code = "\uf445", Code_XML = "&#xf445" });
            r.Add(new FontAwesomeModel() { Name = "ChessQueenAlt", Code = "\uf446", Code_XML = "&#xf446" });
            r.Add(new FontAwesomeModel() { Name = "ChessRook", Code = "\uf447", Code_XML = "&#xf447" });
            r.Add(new FontAwesomeModel() { Name = "ChessRookAlt", Code = "\uf448", Code_XML = "&#xf448" });
            r.Add(new FontAwesomeModel() { Name = "ChevronCircleDown", Code = "\uf13a", Code_XML = "&#xf13a" });
            r.Add(new FontAwesomeModel() { Name = "ChevronCircleLeft", Code = "\uf137", Code_XML = "&#xf137" });
            r.Add(new FontAwesomeModel() { Name = "ChevronCircleRight", Code = "\uf138", Code_XML = "&#xf138" });
            r.Add(new FontAwesomeModel() { Name = "ChevronCircleUp", Code = "\uf139", Code_XML = "&#xf139" });
            r.Add(new FontAwesomeModel() { Name = "ChevronDoubleDown", Code = "\uf322", Code_XML = "&#xf322" });
            r.Add(new FontAwesomeModel() { Name = "ChevronDoubleLeft", Code = "\uf323", Code_XML = "&#xf323" });
            r.Add(new FontAwesomeModel() { Name = "ChevronDoubleRight", Code = "\uf324", Code_XML = "&#xf324" });
            r.Add(new FontAwesomeModel() { Name = "ChevronDoubleUp", Code = "\uf325", Code_XML = "&#xf325" });
            r.Add(new FontAwesomeModel() { Name = "ChevronDown", Code = "\uf078", Code_XML = "&#xf078" });
            r.Add(new FontAwesomeModel() { Name = "ChevronLeft", Code = "\uf053", Code_XML = "&#xf053" });
            r.Add(new FontAwesomeModel() { Name = "ChevronRight", Code = "\uf054", Code_XML = "&#xf054" });
            r.Add(new FontAwesomeModel() { Name = "ChevronSquareDown", Code = "\uf329", Code_XML = "&#xf329" });
            r.Add(new FontAwesomeModel() { Name = "ChevronSquareLeft", Code = "\uf32a", Code_XML = "&#xf32a" });
            r.Add(new FontAwesomeModel() { Name = "ChevronSquareRight", Code = "\uf32b", Code_XML = "&#xf32b" });
            r.Add(new FontAwesomeModel() { Name = "ChevronSquareUp", Code = "\uf32c", Code_XML = "&#xf32c" });
            r.Add(new FontAwesomeModel() { Name = "ChevronUp", Code = "\uf077", Code_XML = "&#xf077" });
            r.Add(new FontAwesomeModel() { Name = "Child", Code = "\uf1ae", Code_XML = "&#xf1ae" });
            r.Add(new FontAwesomeModel() { Name = "Chrome", Code = "\uf268", Code_XML = "&#xf268" });
            r.Add(new FontAwesomeModel() { Name = "Church", Code = "\uf51d", Code_XML = "&#xf51d" });
            r.Add(new FontAwesomeModel() { Name = "Circle", Code = "\uf111", Code_XML = "&#xf111" });
            r.Add(new FontAwesomeModel() { Name = "CircleNotch", Code = "\uf1ce", Code_XML = "&#xf1ce" });
            r.Add(new FontAwesomeModel() { Name = "City", Code = "\uf64f", Code_XML = "&#xf64f" });
            r.Add(new FontAwesomeModel() { Name = "ClawMarks", Code = "\uf6c2", Code_XML = "&#xf6c2" });
            r.Add(new FontAwesomeModel() { Name = "Clipboard", Code = "\uf328", Code_XML = "&#xf328" });
            r.Add(new FontAwesomeModel() { Name = "ClipboardCheck", Code = "\uf46c", Code_XML = "&#xf46c" });
            r.Add(new FontAwesomeModel() { Name = "ClipboardList", Code = "\uf46d", Code_XML = "&#xf46d" });
            r.Add(new FontAwesomeModel() { Name = "ClipboardListCheck", Code = "\uf737", Code_XML = "&#xf737" });
            r.Add(new FontAwesomeModel() { Name = "ClipboardPrescription", Code = "\uf5e8", Code_XML = "&#xf5e8" });
            r.Add(new FontAwesomeModel() { Name = "Clock", Code = "\uf017", Code_XML = "&#xf017" });
            r.Add(new FontAwesomeModel() { Name = "Clone", Code = "\uf24d", Code_XML = "&#xf24d" });
            r.Add(new FontAwesomeModel() { Name = "ClosedCaptioning", Code = "\uf20a", Code_XML = "&#xf20a" });
            r.Add(new FontAwesomeModel() { Name = "Cloud", Code = "\uf0c2", Code_XML = "&#xf0c2" });
            r.Add(new FontAwesomeModel() { Name = "CloudDownload", Code = "\uf0ed", Code_XML = "&#xf0ed" });
            r.Add(new FontAwesomeModel() { Name = "CloudDownloadAlt", Code = "\uf381", Code_XML = "&#xf381" });
            r.Add(new FontAwesomeModel() { Name = "CloudDrizzle", Code = "\uf738", Code_XML = "&#xf738" });
            r.Add(new FontAwesomeModel() { Name = "CloudHail", Code = "\uf739", Code_XML = "&#xf739" });
            r.Add(new FontAwesomeModel() { Name = "CloudHailMixed", Code = "\uf73a", Code_XML = "&#xf73a" });
            r.Add(new FontAwesomeModel() { Name = "CloudMeatball", Code = "\uf73b", Code_XML = "&#xf73b" });
            r.Add(new FontAwesomeModel() { Name = "CloudMoon", Code = "\uf6c3", Code_XML = "&#xf6c3" });
            r.Add(new FontAwesomeModel() { Name = "CloudMoonRain", Code = "\uf73c", Code_XML = "&#xf73c" });
            r.Add(new FontAwesomeModel() { Name = "CloudRain", Code = "\uf73d", Code_XML = "&#xf73d" });
            r.Add(new FontAwesomeModel() { Name = "CloudRainbow", Code = "\uf73e", Code_XML = "&#xf73e" });
            r.Add(new FontAwesomeModel() { Name = "CloudShowers", Code = "\uf73f", Code_XML = "&#xf73f" });
            r.Add(new FontAwesomeModel() { Name = "CloudShowersHeavy", Code = "\uf740", Code_XML = "&#xf740" });
            r.Add(new FontAwesomeModel() { Name = "CloudSleet", Code = "\uf741", Code_XML = "&#xf741" });
            r.Add(new FontAwesomeModel() { Name = "CloudSnow", Code = "\uf742", Code_XML = "&#xf742" });
            r.Add(new FontAwesomeModel() { Name = "CloudSun", Code = "\uf6c4", Code_XML = "&#xf6c4" });
            r.Add(new FontAwesomeModel() { Name = "CloudSunRain", Code = "\uf743", Code_XML = "&#xf743" });
            r.Add(new FontAwesomeModel() { Name = "CloudUpload", Code = "\uf0ee", Code_XML = "&#xf0ee" });
            r.Add(new FontAwesomeModel() { Name = "CloudUploadAlt", Code = "\uf382", Code_XML = "&#xf382" });
            r.Add(new FontAwesomeModel() { Name = "Clouds", Code = "\uf744", Code_XML = "&#xf744" });
            r.Add(new FontAwesomeModel() { Name = "CloudsMoon", Code = "\uf745", Code_XML = "&#xf745" });
            r.Add(new FontAwesomeModel() { Name = "CloudsSun", Code = "\uf746", Code_XML = "&#xf746" });
            r.Add(new FontAwesomeModel() { Name = "Cloudscale", Code = "\uf383", Code_XML = "&#xf383" });
            r.Add(new FontAwesomeModel() { Name = "Cloudsmith", Code = "\uf384", Code_XML = "&#xf384" });
            r.Add(new FontAwesomeModel() { Name = "Cloudversify", Code = "\uf385", Code_XML = "&#xf385" });
            r.Add(new FontAwesomeModel() { Name = "Club", Code = "\uf327", Code_XML = "&#xf327" });
            r.Add(new FontAwesomeModel() { Name = "Cocktail", Code = "\uf561", Code_XML = "&#xf561" });
            r.Add(new FontAwesomeModel() { Name = "Code", Code = "\uf121", Code_XML = "&#xf121" });
            r.Add(new FontAwesomeModel() { Name = "CodeBranch", Code = "\uf126", Code_XML = "&#xf126" });
            r.Add(new FontAwesomeModel() { Name = "CodeCommit", Code = "\uf386", Code_XML = "&#xf386" });
            r.Add(new FontAwesomeModel() { Name = "CodeMerge", Code = "\uf387", Code_XML = "&#xf387" });
            r.Add(new FontAwesomeModel() { Name = "Codepen", Code = "\uf1cb", Code_XML = "&#xf1cb" });
            r.Add(new FontAwesomeModel() { Name = "Codiepie", Code = "\uf284", Code_XML = "&#xf284" });
            r.Add(new FontAwesomeModel() { Name = "Coffee", Code = "\uf0f4", Code_XML = "&#xf0f4" });
            r.Add(new FontAwesomeModel() { Name = "CoffeeTogo", Code = "\uf6c5", Code_XML = "&#xf6c5" });
            r.Add(new FontAwesomeModel() { Name = "Coffin", Code = "\uf6c6", Code_XML = "&#xf6c6" });
            r.Add(new FontAwesomeModel() { Name = "Cog", Code = "\uf013", Code_XML = "&#xf013" });
            r.Add(new FontAwesomeModel() { Name = "Cogs", Code = "\uf085", Code_XML = "&#xf085" });
            r.Add(new FontAwesomeModel() { Name = "Coins", Code = "\uf51e", Code_XML = "&#xf51e" });
            r.Add(new FontAwesomeModel() { Name = "Columns", Code = "\uf0db", Code_XML = "&#xf0db" });
            r.Add(new FontAwesomeModel() { Name = "Comment", Code = "\uf075", Code_XML = "&#xf075" });
            r.Add(new FontAwesomeModel() { Name = "CommentAlt", Code = "\uf27a", Code_XML = "&#xf27a" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltCheck", Code = "\uf4a2", Code_XML = "&#xf4a2" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltDollar", Code = "\uf650", Code_XML = "&#xf650" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltDots", Code = "\uf4a3", Code_XML = "&#xf4a3" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltEdit", Code = "\uf4a4", Code_XML = "&#xf4a4" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltExclamation", Code = "\uf4a5", Code_XML = "&#xf4a5" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltLines", Code = "\uf4a6", Code_XML = "&#xf4a6" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltMinus", Code = "\uf4a7", Code_XML = "&#xf4a7" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltPlus", Code = "\uf4a8", Code_XML = "&#xf4a8" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltSlash", Code = "\uf4a9", Code_XML = "&#xf4a9" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltSmile", Code = "\uf4aa", Code_XML = "&#xf4aa" });
            r.Add(new FontAwesomeModel() { Name = "CommentAltTimes", Code = "\uf4ab", Code_XML = "&#xf4ab" });
            r.Add(new FontAwesomeModel() { Name = "CommentCheck", Code = "\uf4ac", Code_XML = "&#xf4ac" });
            r.Add(new FontAwesomeModel() { Name = "CommentDollar", Code = "\uf651", Code_XML = "&#xf651" });
            r.Add(new FontAwesomeModel() { Name = "CommentDots", Code = "\uf4ad", Code_XML = "&#xf4ad" });
            r.Add(new FontAwesomeModel() { Name = "CommentEdit", Code = "\uf4ae", Code_XML = "&#xf4ae" });
            r.Add(new FontAwesomeModel() { Name = "CommentExclamation", Code = "\uf4af", Code_XML = "&#xf4af" });
            r.Add(new FontAwesomeModel() { Name = "CommentLines", Code = "\uf4b0", Code_XML = "&#xf4b0" });
            r.Add(new FontAwesomeModel() { Name = "CommentMinus", Code = "\uf4b1", Code_XML = "&#xf4b1" });
            r.Add(new FontAwesomeModel() { Name = "CommentPlus", Code = "\uf4b2", Code_XML = "&#xf4b2" });
            r.Add(new FontAwesomeModel() { Name = "CommentSlash", Code = "\uf4b3", Code_XML = "&#xf4b3" });
            r.Add(new FontAwesomeModel() { Name = "CommentSmile", Code = "\uf4b4", Code_XML = "&#xf4b4" });
            r.Add(new FontAwesomeModel() { Name = "CommentTimes", Code = "\uf4b5", Code_XML = "&#xf4b5" });
            r.Add(new FontAwesomeModel() { Name = "Comments", Code = "\uf086", Code_XML = "&#xf086" });
            r.Add(new FontAwesomeModel() { Name = "CommentsAlt", Code = "\uf4b6", Code_XML = "&#xf4b6" });
            r.Add(new FontAwesomeModel() { Name = "CommentsAltDollar", Code = "\uf652", Code_XML = "&#xf652" });
            r.Add(new FontAwesomeModel() { Name = "CommentsDollar", Code = "\uf653", Code_XML = "&#xf653" });
            r.Add(new FontAwesomeModel() { Name = "CompactDisc", Code = "\uf51f", Code_XML = "&#xf51f" });
            r.Add(new FontAwesomeModel() { Name = "Compass", Code = "\uf14e", Code_XML = "&#xf14e" });
            r.Add(new FontAwesomeModel() { Name = "CompassSlash", Code = "\uf5e9", Code_XML = "&#xf5e9" });
            r.Add(new FontAwesomeModel() { Name = "Compress", Code = "\uf066", Code_XML = "&#xf066" });
            r.Add(new FontAwesomeModel() { Name = "CompressAlt", Code = "\uf422", Code_XML = "&#xf422" });
            r.Add(new FontAwesomeModel() { Name = "CompressWide", Code = "\uf326", Code_XML = "&#xf326" });
            r.Add(new FontAwesomeModel() { Name = "ConciergeBell", Code = "\uf562", Code_XML = "&#xf562" });
            r.Add(new FontAwesomeModel() { Name = "Connectdevelop", Code = "\uf20e", Code_XML = "&#xf20e" });
            r.Add(new FontAwesomeModel() { Name = "ContainerStorage", Code = "\uf4b7", Code_XML = "&#xf4b7" });
            r.Add(new FontAwesomeModel() { Name = "Contao", Code = "\uf26d", Code_XML = "&#xf26d" });
            r.Add(new FontAwesomeModel() { Name = "ConveyorBelt", Code = "\uf46e", Code_XML = "&#xf46e" });
            r.Add(new FontAwesomeModel() { Name = "ConveyorBeltAlt", Code = "\uf46f", Code_XML = "&#xf46f" });
            r.Add(new FontAwesomeModel() { Name = "Cookie", Code = "\uf563", Code_XML = "&#xf563" });
            r.Add(new FontAwesomeModel() { Name = "CookieBite", Code = "\uf564", Code_XML = "&#xf564" });
            r.Add(new FontAwesomeModel() { Name = "Copy", Code = "\uf0c5", Code_XML = "&#xf0c5" });
            r.Add(new FontAwesomeModel() { Name = "Copyright", Code = "\uf1f9", Code_XML = "&#xf1f9" });
            r.Add(new FontAwesomeModel() { Name = "Corn", Code = "\uf6c7", Code_XML = "&#xf6c7" });
            r.Add(new FontAwesomeModel() { Name = "Couch", Code = "\uf4b8", Code_XML = "&#xf4b8" });
            r.Add(new FontAwesomeModel() { Name = "Cow", Code = "\uf6c8", Code_XML = "&#xf6c8" });
            r.Add(new FontAwesomeModel() { Name = "Cpanel", Code = "\uf388", Code_XML = "&#xf388" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommons", Code = "\uf25e", Code_XML = "&#xf25e" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsBy", Code = "\uf4e7", Code_XML = "&#xf4e7" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsNc", Code = "\uf4e8", Code_XML = "&#xf4e8" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsNcEu", Code = "\uf4e9", Code_XML = "&#xf4e9" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsNcJp", Code = "\uf4ea", Code_XML = "&#xf4ea" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsNd", Code = "\uf4eb", Code_XML = "&#xf4eb" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsPd", Code = "\uf4ec", Code_XML = "&#xf4ec" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsPdAlt", Code = "\uf4ed", Code_XML = "&#xf4ed" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsRemix", Code = "\uf4ee", Code_XML = "&#xf4ee" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsSa", Code = "\uf4ef", Code_XML = "&#xf4ef" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsSampling", Code = "\uf4f0", Code_XML = "&#xf4f0" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsSamplingPlus", Code = "\uf4f1", Code_XML = "&#xf4f1" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsShare", Code = "\uf4f2", Code_XML = "&#xf4f2" });
            r.Add(new FontAwesomeModel() { Name = "CreativeCommonsZero", Code = "\uf4f3", Code_XML = "&#xf4f3" });
            r.Add(new FontAwesomeModel() { Name = "CreditCard", Code = "\uf09d", Code_XML = "&#xf09d" });
            r.Add(new FontAwesomeModel() { Name = "CreditCardBlank", Code = "\uf389", Code_XML = "&#xf389" });
            r.Add(new FontAwesomeModel() { Name = "CreditCardFront", Code = "\uf38a", Code_XML = "&#xf38a" });
            r.Add(new FontAwesomeModel() { Name = "Cricket", Code = "\uf449", Code_XML = "&#xf449" });
            r.Add(new FontAwesomeModel() { Name = "CriticalRole", Code = "\uf6c9", Code_XML = "&#xf6c9" });
            r.Add(new FontAwesomeModel() { Name = "Crop", Code = "\uf125", Code_XML = "&#xf125" });
            r.Add(new FontAwesomeModel() { Name = "CropAlt", Code = "\uf565", Code_XML = "&#xf565" });
            r.Add(new FontAwesomeModel() { Name = "Cross", Code = "\uf654", Code_XML = "&#xf654" });
            r.Add(new FontAwesomeModel() { Name = "Crosshairs", Code = "\uf05b", Code_XML = "&#xf05b" });
            r.Add(new FontAwesomeModel() { Name = "Crow", Code = "\uf520", Code_XML = "&#xf520" });
            r.Add(new FontAwesomeModel() { Name = "Crown", Code = "\uf521", Code_XML = "&#xf521" });
            r.Add(new FontAwesomeModel() { Name = "Css3", Code = "\uf13c", Code_XML = "&#xf13c" });
            r.Add(new FontAwesomeModel() { Name = "Css3Alt", Code = "\uf38b", Code_XML = "&#xf38b" });
            r.Add(new FontAwesomeModel() { Name = "Cube", Code = "\uf1b2", Code_XML = "&#xf1b2" });
            r.Add(new FontAwesomeModel() { Name = "Cubes", Code = "\uf1b3", Code_XML = "&#xf1b3" });
            r.Add(new FontAwesomeModel() { Name = "Curling", Code = "\uf44a", Code_XML = "&#xf44a" });
            r.Add(new FontAwesomeModel() { Name = "Cut", Code = "\uf0c4", Code_XML = "&#xf0c4" });
            r.Add(new FontAwesomeModel() { Name = "Cuttlefish", Code = "\uf38c", Code_XML = "&#xf38c" });
            r.Add(new FontAwesomeModel() { Name = "DAndD", Code = "\uf38d", Code_XML = "&#xf38d" });
            r.Add(new FontAwesomeModel() { Name = "DAndDBeyond", Code = "\uf6ca", Code_XML = "&#xf6ca" });
            r.Add(new FontAwesomeModel() { Name = "Dagger", Code = "\uf6cb", Code_XML = "&#xf6cb" });
            r.Add(new FontAwesomeModel() { Name = "Dashcube", Code = "\uf210", Code_XML = "&#xf210" });
            r.Add(new FontAwesomeModel() { Name = "Database", Code = "\uf1c0", Code_XML = "&#xf1c0" });
            r.Add(new FontAwesomeModel() { Name = "Deaf", Code = "\uf2a4", Code_XML = "&#xf2a4" });
            r.Add(new FontAwesomeModel() { Name = "Delicious", Code = "\uf1a5", Code_XML = "&#xf1a5" });
            r.Add(new FontAwesomeModel() { Name = "Democrat", Code = "\uf747", Code_XML = "&#xf747" });
            r.Add(new FontAwesomeModel() { Name = "Deploydog", Code = "\uf38e", Code_XML = "&#xf38e" });
            r.Add(new FontAwesomeModel() { Name = "Deskpro", Code = "\uf38f", Code_XML = "&#xf38f" });
            r.Add(new FontAwesomeModel() { Name = "Desktop", Code = "\uf108", Code_XML = "&#xf108" });
            r.Add(new FontAwesomeModel() { Name = "DesktopAlt", Code = "\uf390", Code_XML = "&#xf390" });
            r.Add(new FontAwesomeModel() { Name = "Dev", Code = "\uf6cc", Code_XML = "&#xf6cc" });
            r.Add(new FontAwesomeModel() { Name = "Deviantart", Code = "\uf1bd", Code_XML = "&#xf1bd" });
            r.Add(new FontAwesomeModel() { Name = "Dewpoint", Code = "\uf748", Code_XML = "&#xf748" });
            r.Add(new FontAwesomeModel() { Name = "Dharmachakra", Code = "\uf655", Code_XML = "&#xf655" });
            r.Add(new FontAwesomeModel() { Name = "Diagnoses", Code = "\uf470", Code_XML = "&#xf470" });
            r.Add(new FontAwesomeModel() { Name = "Diamond", Code = "\uf219", Code_XML = "&#xf219" });
            r.Add(new FontAwesomeModel() { Name = "Dice", Code = "\uf522", Code_XML = "&#xf522" });
            r.Add(new FontAwesomeModel() { Name = "DiceD10", Code = "\uf6cd", Code_XML = "&#xf6cd" });
            r.Add(new FontAwesomeModel() { Name = "DiceD12", Code = "\uf6ce", Code_XML = "&#xf6ce" });
            r.Add(new FontAwesomeModel() { Name = "DiceD20", Code = "\uf6cf", Code_XML = "&#xf6cf" });
            r.Add(new FontAwesomeModel() { Name = "DiceD4", Code = "\uf6d0", Code_XML = "&#xf6d0" });
            r.Add(new FontAwesomeModel() { Name = "DiceD6", Code = "\uf6d1", Code_XML = "&#xf6d1" });
            r.Add(new FontAwesomeModel() { Name = "DiceD8", Code = "\uf6d2", Code_XML = "&#xf6d2" });
            r.Add(new FontAwesomeModel() { Name = "DiceFive", Code = "\uf523", Code_XML = "&#xf523" });
            r.Add(new FontAwesomeModel() { Name = "DiceFour", Code = "\uf524", Code_XML = "&#xf524" });
            r.Add(new FontAwesomeModel() { Name = "DiceOne", Code = "\uf525", Code_XML = "&#xf525" });
            r.Add(new FontAwesomeModel() { Name = "DiceSix", Code = "\uf526", Code_XML = "&#xf526" });
            r.Add(new FontAwesomeModel() { Name = "DiceThree", Code = "\uf527", Code_XML = "&#xf527" });
            r.Add(new FontAwesomeModel() { Name = "DiceTwo", Code = "\uf528", Code_XML = "&#xf528" });
            r.Add(new FontAwesomeModel() { Name = "Digg", Code = "\uf1a6", Code_XML = "&#xf1a6" });
            r.Add(new FontAwesomeModel() { Name = "DigitalOcean", Code = "\uf391", Code_XML = "&#xf391" });
            r.Add(new FontAwesomeModel() { Name = "DigitalTachograph", Code = "\uf566", Code_XML = "&#xf566" });
            r.Add(new FontAwesomeModel() { Name = "Diploma", Code = "\uf5ea", Code_XML = "&#xf5ea" });
            r.Add(new FontAwesomeModel() { Name = "Directions", Code = "\uf5eb", Code_XML = "&#xf5eb" });
            r.Add(new FontAwesomeModel() { Name = "Discord", Code = "\uf392", Code_XML = "&#xf392" });
            r.Add(new FontAwesomeModel() { Name = "Discourse", Code = "\uf393", Code_XML = "&#xf393" });
            r.Add(new FontAwesomeModel() { Name = "Divide", Code = "\uf529", Code_XML = "&#xf529" });
            r.Add(new FontAwesomeModel() { Name = "Dizzy", Code = "\uf567", Code_XML = "&#xf567" });
            r.Add(new FontAwesomeModel() { Name = "Dna", Code = "\uf471", Code_XML = "&#xf471" });
            r.Add(new FontAwesomeModel() { Name = "DoNotEnter", Code = "\uf5ec", Code_XML = "&#xf5ec" });
            r.Add(new FontAwesomeModel() { Name = "Dochub", Code = "\uf394", Code_XML = "&#xf394" });
            r.Add(new FontAwesomeModel() { Name = "Docker", Code = "\uf395", Code_XML = "&#xf395" });
            r.Add(new FontAwesomeModel() { Name = "Dog", Code = "\uf6d3", Code_XML = "&#xf6d3" });
            r.Add(new FontAwesomeModel() { Name = "DogLeashed", Code = "\uf6d4", Code_XML = "&#xf6d4" });
            r.Add(new FontAwesomeModel() { Name = "DollarSign", Code = "\uf155", Code_XML = "&#xf155" });
            r.Add(new FontAwesomeModel() { Name = "Dolly", Code = "\uf472", Code_XML = "&#xf472" });
            r.Add(new FontAwesomeModel() { Name = "DollyEmpty", Code = "\uf473", Code_XML = "&#xf473" });
            r.Add(new FontAwesomeModel() { Name = "DollyFlatbed", Code = "\uf474", Code_XML = "&#xf474" });
            r.Add(new FontAwesomeModel() { Name = "DollyFlatbedAlt", Code = "\uf475", Code_XML = "&#xf475" });
            r.Add(new FontAwesomeModel() { Name = "DollyFlatbedEmpty", Code = "\uf476", Code_XML = "&#xf476" });
            r.Add(new FontAwesomeModel() { Name = "Donate", Code = "\uf4b9", Code_XML = "&#xf4b9" });
            r.Add(new FontAwesomeModel() { Name = "DoorClosed", Code = "\uf52a", Code_XML = "&#xf52a" });
            r.Add(new FontAwesomeModel() { Name = "DoorOpen", Code = "\uf52b", Code_XML = "&#xf52b" });
            r.Add(new FontAwesomeModel() { Name = "DotCircle", Code = "\uf192", Code_XML = "&#xf192" });
            r.Add(new FontAwesomeModel() { Name = "Dove", Code = "\uf4ba", Code_XML = "&#xf4ba" });
            r.Add(new FontAwesomeModel() { Name = "Download", Code = "\uf019", Code_XML = "&#xf019" });
            r.Add(new FontAwesomeModel() { Name = "Draft2digital", Code = "\uf396", Code_XML = "&#xf396" });
            r.Add(new FontAwesomeModel() { Name = "DraftingCompass", Code = "\uf568", Code_XML = "&#xf568" });
            r.Add(new FontAwesomeModel() { Name = "Dragon", Code = "\uf6d5", Code_XML = "&#xf6d5" });
            r.Add(new FontAwesomeModel() { Name = "DrawCircle", Code = "\uf5ed", Code_XML = "&#xf5ed" });
            r.Add(new FontAwesomeModel() { Name = "DrawPolygon", Code = "\uf5ee", Code_XML = "&#xf5ee" });
            r.Add(new FontAwesomeModel() { Name = "DrawSquare", Code = "\uf5ef", Code_XML = "&#xf5ef" });
            r.Add(new FontAwesomeModel() { Name = "Dribbble", Code = "\uf17d", Code_XML = "&#xf17d" });
            r.Add(new FontAwesomeModel() { Name = "DribbbleSquare", Code = "\uf397", Code_XML = "&#xf397" });
            r.Add(new FontAwesomeModel() { Name = "Dropbox", Code = "\uf16b", Code_XML = "&#xf16b" });
            r.Add(new FontAwesomeModel() { Name = "Drum", Code = "\uf569", Code_XML = "&#xf569" });
            r.Add(new FontAwesomeModel() { Name = "DrumSteelpan", Code = "\uf56a", Code_XML = "&#xf56a" });
            r.Add(new FontAwesomeModel() { Name = "Drumstick", Code = "\uf6d6", Code_XML = "&#xf6d6" });
            r.Add(new FontAwesomeModel() { Name = "DrumstickBite", Code = "\uf6d7", Code_XML = "&#xf6d7" });
            r.Add(new FontAwesomeModel() { Name = "Drupal", Code = "\uf1a9", Code_XML = "&#xf1a9" });
            r.Add(new FontAwesomeModel() { Name = "Duck", Code = "\uf6d8", Code_XML = "&#xf6d8" });
            r.Add(new FontAwesomeModel() { Name = "Dumbbell", Code = "\uf44b", Code_XML = "&#xf44b" });
            r.Add(new FontAwesomeModel() { Name = "Dungeon", Code = "\uf6d9", Code_XML = "&#xf6d9" });
            r.Add(new FontAwesomeModel() { Name = "Dyalog", Code = "\uf399", Code_XML = "&#xf399" });
            r.Add(new FontAwesomeModel() { Name = "Ear", Code = "\uf5f0", Code_XML = "&#xf5f0" });
            r.Add(new FontAwesomeModel() { Name = "Earlybirds", Code = "\uf39a", Code_XML = "&#xf39a" });
            r.Add(new FontAwesomeModel() { Name = "Ebay", Code = "\uf4f4", Code_XML = "&#xf4f4" });
            r.Add(new FontAwesomeModel() { Name = "Eclipse", Code = "\uf749", Code_XML = "&#xf749" });
            r.Add(new FontAwesomeModel() { Name = "EclipseAlt", Code = "\uf74a", Code_XML = "&#xf74a" });
            r.Add(new FontAwesomeModel() { Name = "Edge", Code = "\uf282", Code_XML = "&#xf282" });
            r.Add(new FontAwesomeModel() { Name = "Edit", Code = "\uf044", Code_XML = "&#xf044" });
            r.Add(new FontAwesomeModel() { Name = "Eject", Code = "\uf052", Code_XML = "&#xf052" });
            r.Add(new FontAwesomeModel() { Name = "Elementor", Code = "\uf430", Code_XML = "&#xf430" });
            r.Add(new FontAwesomeModel() { Name = "Elephant", Code = "\uf6da", Code_XML = "&#xf6da" });
            r.Add(new FontAwesomeModel() { Name = "EllipsisH", Code = "\uf141", Code_XML = "&#xf141" });
            r.Add(new FontAwesomeModel() { Name = "EllipsisHAlt", Code = "\uf39b", Code_XML = "&#xf39b" });
            r.Add(new FontAwesomeModel() { Name = "EllipsisV", Code = "\uf142", Code_XML = "&#xf142" });
            r.Add(new FontAwesomeModel() { Name = "EllipsisVAlt", Code = "\uf39c", Code_XML = "&#xf39c" });
            r.Add(new FontAwesomeModel() { Name = "Ello", Code = "\uf5f1", Code_XML = "&#xf5f1" });
            r.Add(new FontAwesomeModel() { Name = "Ember", Code = "\uf423", Code_XML = "&#xf423" });
            r.Add(new FontAwesomeModel() { Name = "Empire", Code = "\uf1d1", Code_XML = "&#xf1d1" });
            r.Add(new FontAwesomeModel() { Name = "EmptySet", Code = "\uf656", Code_XML = "&#xf656" });
            r.Add(new FontAwesomeModel() { Name = "EngineWarning", Code = "\uf5f2", Code_XML = "&#xf5f2" });
            r.Add(new FontAwesomeModel() { Name = "Envelope", Code = "\uf0e0", Code_XML = "&#xf0e0" });
            r.Add(new FontAwesomeModel() { Name = "EnvelopeOpen", Code = "\uf2b6", Code_XML = "&#xf2b6" });
            r.Add(new FontAwesomeModel() { Name = "EnvelopeOpenDollar", Code = "\uf657", Code_XML = "&#xf657" });
            r.Add(new FontAwesomeModel() { Name = "EnvelopeOpenText", Code = "\uf658", Code_XML = "&#xf658" });
            r.Add(new FontAwesomeModel() { Name = "EnvelopeSquare", Code = "\uf199", Code_XML = "&#xf199" });
            r.Add(new FontAwesomeModel() { Name = "Envira", Code = "\uf299", Code_XML = "&#xf299" });
            r.Add(new FontAwesomeModel() { Name = "Equals", Code = "\uf52c", Code_XML = "&#xf52c" });
            r.Add(new FontAwesomeModel() { Name = "Eraser", Code = "\uf12d", Code_XML = "&#xf12d" });
            r.Add(new FontAwesomeModel() { Name = "Erlang", Code = "\uf39d", Code_XML = "&#xf39d" });
            r.Add(new FontAwesomeModel() { Name = "Ethereum", Code = "\uf42e", Code_XML = "&#xf42e" });
            r.Add(new FontAwesomeModel() { Name = "Etsy", Code = "\uf2d7", Code_XML = "&#xf2d7" });
            r.Add(new FontAwesomeModel() { Name = "EuroSign", Code = "\uf153", Code_XML = "&#xf153" });
            r.Add(new FontAwesomeModel() { Name = "Exchange", Code = "\uf0ec", Code_XML = "&#xf0ec" });
            r.Add(new FontAwesomeModel() { Name = "ExchangeAlt", Code = "\uf362", Code_XML = "&#xf362" });
            r.Add(new FontAwesomeModel() { Name = "Exclamation", Code = "\uf12a", Code_XML = "&#xf12a" });
            r.Add(new FontAwesomeModel() { Name = "ExclamationCircle", Code = "\uf06a", Code_XML = "&#xf06a" });
            r.Add(new FontAwesomeModel() { Name = "ExclamationSquare", Code = "\uf321", Code_XML = "&#xf321" });
            r.Add(new FontAwesomeModel() { Name = "ExclamationTriangle", Code = "\uf071", Code_XML = "&#xf071" });
            r.Add(new FontAwesomeModel() { Name = "Expand", Code = "\uf065", Code_XML = "&#xf065" });
            r.Add(new FontAwesomeModel() { Name = "ExpandAlt", Code = "\uf424", Code_XML = "&#xf424" });
            r.Add(new FontAwesomeModel() { Name = "ExpandArrows", Code = "\uf31d", Code_XML = "&#xf31d" });
            r.Add(new FontAwesomeModel() { Name = "ExpandArrowsAlt", Code = "\uf31e", Code_XML = "&#xf31e" });
            r.Add(new FontAwesomeModel() { Name = "ExpandWide", Code = "\uf320", Code_XML = "&#xf320" });
            r.Add(new FontAwesomeModel() { Name = "Expeditedssl", Code = "\uf23e", Code_XML = "&#xf23e" });
            r.Add(new FontAwesomeModel() { Name = "ExternalLink", Code = "\uf08e", Code_XML = "&#xf08e" });
            r.Add(new FontAwesomeModel() { Name = "ExternalLinkAlt", Code = "\uf35d", Code_XML = "&#xf35d" });
            r.Add(new FontAwesomeModel() { Name = "ExternalLinkSquare", Code = "\uf14c", Code_XML = "&#xf14c" });
            r.Add(new FontAwesomeModel() { Name = "ExternalLinkSquareAlt", Code = "\uf360", Code_XML = "&#xf360" });
            r.Add(new FontAwesomeModel() { Name = "Eye", Code = "\uf06e", Code_XML = "&#xf06e" });
            r.Add(new FontAwesomeModel() { Name = "EyeDropper", Code = "\uf1fb", Code_XML = "&#xf1fb" });
            r.Add(new FontAwesomeModel() { Name = "EyeEvil", Code = "\uf6db", Code_XML = "&#xf6db" });
            r.Add(new FontAwesomeModel() { Name = "EyeSlash", Code = "\uf070", Code_XML = "&#xf070" });
            r.Add(new FontAwesomeModel() { Name = "Facebook", Code = "\uf09a", Code_XML = "&#xf09a" });
            r.Add(new FontAwesomeModel() { Name = "FacebookF", Code = "\uf39e", Code_XML = "&#xf39e" });
            r.Add(new FontAwesomeModel() { Name = "FacebookMessenger", Code = "\uf39f", Code_XML = "&#xf39f" });
            r.Add(new FontAwesomeModel() { Name = "FacebookSquare", Code = "\uf082", Code_XML = "&#xf082" });
            r.Add(new FontAwesomeModel() { Name = "FantasyFlightGames", Code = "\uf6dc", Code_XML = "&#xf6dc" });
            r.Add(new FontAwesomeModel() { Name = "FastBackward", Code = "\uf049", Code_XML = "&#xf049" });
            r.Add(new FontAwesomeModel() { Name = "FastForward", Code = "\uf050", Code_XML = "&#xf050" });
            r.Add(new FontAwesomeModel() { Name = "Fax", Code = "\uf1ac", Code_XML = "&#xf1ac" });
            r.Add(new FontAwesomeModel() { Name = "Feather", Code = "\uf52d", Code_XML = "&#xf52d" });
            r.Add(new FontAwesomeModel() { Name = "FeatherAlt", Code = "\uf56b", Code_XML = "&#xf56b" });
            r.Add(new FontAwesomeModel() { Name = "Female", Code = "\uf182", Code_XML = "&#xf182" });
            r.Add(new FontAwesomeModel() { Name = "FieldHockey", Code = "\uf44c", Code_XML = "&#xf44c" });
            r.Add(new FontAwesomeModel() { Name = "FighterJet", Code = "\uf0fb", Code_XML = "&#xf0fb" });
            r.Add(new FontAwesomeModel() { Name = "File", Code = "\uf15b", Code_XML = "&#xf15b" });
            r.Add(new FontAwesomeModel() { Name = "FileAlt", Code = "\uf15c", Code_XML = "&#xf15c" });
            r.Add(new FontAwesomeModel() { Name = "FileArchive", Code = "\uf1c6", Code_XML = "&#xf1c6" });
            r.Add(new FontAwesomeModel() { Name = "FileAudio", Code = "\uf1c7", Code_XML = "&#xf1c7" });
            r.Add(new FontAwesomeModel() { Name = "FileCertificate", Code = "\uf5f3", Code_XML = "&#xf5f3" });
            r.Add(new FontAwesomeModel() { Name = "FileChartLine", Code = "\uf659", Code_XML = "&#xf659" });
            r.Add(new FontAwesomeModel() { Name = "FileChartPie", Code = "\uf65a", Code_XML = "&#xf65a" });
            r.Add(new FontAwesomeModel() { Name = "FileCheck", Code = "\uf316", Code_XML = "&#xf316" });
            r.Add(new FontAwesomeModel() { Name = "FileCode", Code = "\uf1c9", Code_XML = "&#xf1c9" });
            r.Add(new FontAwesomeModel() { Name = "FileContract", Code = "\uf56c", Code_XML = "&#xf56c" });
            r.Add(new FontAwesomeModel() { Name = "FileCsv", Code = "\uf6dd", Code_XML = "&#xf6dd" });
            r.Add(new FontAwesomeModel() { Name = "FileDownload", Code = "\uf56d", Code_XML = "&#xf56d" });
            r.Add(new FontAwesomeModel() { Name = "FileEdit", Code = "\uf31c", Code_XML = "&#xf31c" });
            r.Add(new FontAwesomeModel() { Name = "FileExcel", Code = "\uf1c3", Code_XML = "&#xf1c3" });
            r.Add(new FontAwesomeModel() { Name = "FileExclamation", Code = "\uf31a", Code_XML = "&#xf31a" });
            r.Add(new FontAwesomeModel() { Name = "FileExport", Code = "\uf56e", Code_XML = "&#xf56e" });
            r.Add(new FontAwesomeModel() { Name = "FileImage", Code = "\uf1c5", Code_XML = "&#xf1c5" });
            r.Add(new FontAwesomeModel() { Name = "FileImport", Code = "\uf56f", Code_XML = "&#xf56f" });
            r.Add(new FontAwesomeModel() { Name = "FileInvoice", Code = "\uf570", Code_XML = "&#xf570" });
            r.Add(new FontAwesomeModel() { Name = "FileInvoiceDollar", Code = "\uf571", Code_XML = "&#xf571" });
            r.Add(new FontAwesomeModel() { Name = "FileMedical", Code = "\uf477", Code_XML = "&#xf477" });
            r.Add(new FontAwesomeModel() { Name = "FileMedicalAlt", Code = "\uf478", Code_XML = "&#xf478" });
            r.Add(new FontAwesomeModel() { Name = "FileMinus", Code = "\uf318", Code_XML = "&#xf318" });
            r.Add(new FontAwesomeModel() { Name = "FilePdf", Code = "\uf1c1", Code_XML = "&#xf1c1" });
            r.Add(new FontAwesomeModel() { Name = "FilePlus", Code = "\uf319", Code_XML = "&#xf319" });
            r.Add(new FontAwesomeModel() { Name = "FilePowerpoint", Code = "\uf1c4", Code_XML = "&#xf1c4" });
            r.Add(new FontAwesomeModel() { Name = "FilePrescription", Code = "\uf572", Code_XML = "&#xf572" });
            r.Add(new FontAwesomeModel() { Name = "FileSignature", Code = "\uf573", Code_XML = "&#xf573" });
            r.Add(new FontAwesomeModel() { Name = "FileSpreadsheet", Code = "\uf65b", Code_XML = "&#xf65b" });
            r.Add(new FontAwesomeModel() { Name = "FileTimes", Code = "\uf317", Code_XML = "&#xf317" });
            r.Add(new FontAwesomeModel() { Name = "FileUpload", Code = "\uf574", Code_XML = "&#xf574" });
            r.Add(new FontAwesomeModel() { Name = "FileUser", Code = "\uf65c", Code_XML = "&#xf65c" });
            r.Add(new FontAwesomeModel() { Name = "FileVideo", Code = "\uf1c8", Code_XML = "&#xf1c8" });
            r.Add(new FontAwesomeModel() { Name = "FileWord", Code = "\uf1c2", Code_XML = "&#xf1c2" });
            r.Add(new FontAwesomeModel() { Name = "Fill", Code = "\uf575", Code_XML = "&#xf575" });
            r.Add(new FontAwesomeModel() { Name = "FillDrip", Code = "\uf576", Code_XML = "&#xf576" });
            r.Add(new FontAwesomeModel() { Name = "Film", Code = "\uf008", Code_XML = "&#xf008" });
            r.Add(new FontAwesomeModel() { Name = "FilmAlt", Code = "\uf3a0", Code_XML = "&#xf3a0" });
            r.Add(new FontAwesomeModel() { Name = "Filter", Code = "\uf0b0", Code_XML = "&#xf0b0" });
            r.Add(new FontAwesomeModel() { Name = "Fingerprint", Code = "\uf577", Code_XML = "&#xf577" });
            r.Add(new FontAwesomeModel() { Name = "Fire", Code = "\uf06d", Code_XML = "&#xf06d" });
            r.Add(new FontAwesomeModel() { Name = "FireExtinguisher", Code = "\uf134", Code_XML = "&#xf134" });
            r.Add(new FontAwesomeModel() { Name = "FireSmoke", Code = "\uf74b", Code_XML = "&#xf74b" });
            r.Add(new FontAwesomeModel() { Name = "Firefox", Code = "\uf269", Code_XML = "&#xf269" });
            r.Add(new FontAwesomeModel() { Name = "FirstAid", Code = "\uf479", Code_XML = "&#xf479" });
            r.Add(new FontAwesomeModel() { Name = "FirstOrder", Code = "\uf2b0", Code_XML = "&#xf2b0" });
            r.Add(new FontAwesomeModel() { Name = "FirstOrderAlt", Code = "\uf50a", Code_XML = "&#xf50a" });
            r.Add(new FontAwesomeModel() { Name = "Firstdraft", Code = "\uf3a1", Code_XML = "&#xf3a1" });
            r.Add(new FontAwesomeModel() { Name = "Fish", Code = "\uf578", Code_XML = "&#xf578" });
            r.Add(new FontAwesomeModel() { Name = "FistRaised", Code = "\uf6de", Code_XML = "&#xf6de" });
			r.Add(new FontAwesomeModel() { Name = "FiveHundredPX", Code = "\uf26e", Code_XML = "&#xf26e" });
            r.Add(new FontAwesomeModel() { Name = "Flag", Code = "\uf024", Code_XML = "&#xf024" });
            r.Add(new FontAwesomeModel() { Name = "FlagAlt", Code = "\uf74c", Code_XML = "&#xf74c" });
            r.Add(new FontAwesomeModel() { Name = "FlagCheckered", Code = "\uf11e", Code_XML = "&#xf11e" });
            r.Add(new FontAwesomeModel() { Name = "FlagUsa", Code = "\uf74d", Code_XML = "&#xf74d" });
            r.Add(new FontAwesomeModel() { Name = "Flame", Code = "\uf6df", Code_XML = "&#xf6df" });
            r.Add(new FontAwesomeModel() { Name = "Flask", Code = "\uf0c3", Code_XML = "&#xf0c3" });
            r.Add(new FontAwesomeModel() { Name = "FlaskPoison", Code = "\uf6e0", Code_XML = "&#xf6e0" });
            r.Add(new FontAwesomeModel() { Name = "FlaskPotion", Code = "\uf6e1", Code_XML = "&#xf6e1" });
            r.Add(new FontAwesomeModel() { Name = "Flickr", Code = "\uf16e", Code_XML = "&#xf16e" });
            r.Add(new FontAwesomeModel() { Name = "Flipboard", Code = "\uf44d", Code_XML = "&#xf44d" });
            r.Add(new FontAwesomeModel() { Name = "Flushed", Code = "\uf579", Code_XML = "&#xf579" });
            r.Add(new FontAwesomeModel() { Name = "Fly", Code = "\uf417", Code_XML = "&#xf417" });
            r.Add(new FontAwesomeModel() { Name = "Fog", Code = "\uf74e", Code_XML = "&#xf74e" });
            r.Add(new FontAwesomeModel() { Name = "Folder", Code = "\uf07b", Code_XML = "&#xf07b" });
            r.Add(new FontAwesomeModel() { Name = "FolderMinus", Code = "\uf65d", Code_XML = "&#xf65d" });
            r.Add(new FontAwesomeModel() { Name = "FolderOpen", Code = "\uf07c", Code_XML = "&#xf07c" });
            r.Add(new FontAwesomeModel() { Name = "FolderPlus", Code = "\uf65e", Code_XML = "&#xf65e" });
            r.Add(new FontAwesomeModel() { Name = "FolderTimes", Code = "\uf65f", Code_XML = "&#xf65f" });
            r.Add(new FontAwesomeModel() { Name = "Folders", Code = "\uf660", Code_XML = "&#xf660" });
            r.Add(new FontAwesomeModel() { Name = "Font", Code = "\uf031", Code_XML = "&#xf031" });
            r.Add(new FontAwesomeModel() { Name = "FontAwesome", Code = "\uf2b4", Code_XML = "&#xf2b4" });
            r.Add(new FontAwesomeModel() { Name = "FontAwesomeAlt", Code = "\uf35c", Code_XML = "&#xf35c" });
            r.Add(new FontAwesomeModel() { Name = "FontAwesomeFlag", Code = "\uf425", Code_XML = "&#xf425" });
            r.Add(new FontAwesomeModel() { Name = "Fonticons", Code = "\uf280", Code_XML = "&#xf280" });
            r.Add(new FontAwesomeModel() { Name = "FonticonsFi", Code = "\uf3a2", Code_XML = "&#xf3a2" });
            r.Add(new FontAwesomeModel() { Name = "FootballBall", Code = "\uf44e", Code_XML = "&#xf44e" });
            r.Add(new FontAwesomeModel() { Name = "FootballHelmet", Code = "\uf44f", Code_XML = "&#xf44f" });
            r.Add(new FontAwesomeModel() { Name = "Forklift", Code = "\uf47a", Code_XML = "&#xf47a" });
            r.Add(new FontAwesomeModel() { Name = "FortAwesome", Code = "\uf286", Code_XML = "&#xf286" });
            r.Add(new FontAwesomeModel() { Name = "FortAwesomeAlt", Code = "\uf3a3", Code_XML = "&#xf3a3" });
            r.Add(new FontAwesomeModel() { Name = "Forumbee", Code = "\uf211", Code_XML = "&#xf211" });
            r.Add(new FontAwesomeModel() { Name = "Forward", Code = "\uf04e", Code_XML = "&#xf04e" });
            r.Add(new FontAwesomeModel() { Name = "Foursquare", Code = "\uf180", Code_XML = "&#xf180" });
            r.Add(new FontAwesomeModel() { Name = "Fragile", Code = "\uf4bb", Code_XML = "&#xf4bb" });
            r.Add(new FontAwesomeModel() { Name = "FreeCodeCamp", Code = "\uf2c5", Code_XML = "&#xf2c5" });
            r.Add(new FontAwesomeModel() { Name = "Freebsd", Code = "\uf3a4", Code_XML = "&#xf3a4" });
            r.Add(new FontAwesomeModel() { Name = "Frog", Code = "\uf52e", Code_XML = "&#xf52e" });
            r.Add(new FontAwesomeModel() { Name = "Frown", Code = "\uf119", Code_XML = "&#xf119" });
            r.Add(new FontAwesomeModel() { Name = "FrownOpen", Code = "\uf57a", Code_XML = "&#xf57a" });
            r.Add(new FontAwesomeModel() { Name = "Fulcrum", Code = "\uf50b", Code_XML = "&#xf50b" });
            r.Add(new FontAwesomeModel() { Name = "Function", Code = "\uf661", Code_XML = "&#xf661" });
            r.Add(new FontAwesomeModel() { Name = "FunnelDollar", Code = "\uf662", Code_XML = "&#xf662" });
            r.Add(new FontAwesomeModel() { Name = "Futbol", Code = "\uf1e3", Code_XML = "&#xf1e3" });
            r.Add(new FontAwesomeModel() { Name = "GalacticRepublic", Code = "\uf50c", Code_XML = "&#xf50c" });
            r.Add(new FontAwesomeModel() { Name = "GalacticSenate", Code = "\uf50d", Code_XML = "&#xf50d" });
            r.Add(new FontAwesomeModel() { Name = "Gamepad", Code = "\uf11b", Code_XML = "&#xf11b" });
            r.Add(new FontAwesomeModel() { Name = "GasPump", Code = "\uf52f", Code_XML = "&#xf52f" });
            r.Add(new FontAwesomeModel() { Name = "GasPumpSlash", Code = "\uf5f4", Code_XML = "&#xf5f4" });
            r.Add(new FontAwesomeModel() { Name = "Gavel", Code = "\uf0e3", Code_XML = "&#xf0e3" });
            r.Add(new FontAwesomeModel() { Name = "Gem", Code = "\uf3a5", Code_XML = "&#xf3a5" });
            r.Add(new FontAwesomeModel() { Name = "Genderless", Code = "\uf22d", Code_XML = "&#xf22d" });
            r.Add(new FontAwesomeModel() { Name = "GetPocket", Code = "\uf265", Code_XML = "&#xf265" });
            r.Add(new FontAwesomeModel() { Name = "Gg", Code = "\uf260", Code_XML = "&#xf260" });
            r.Add(new FontAwesomeModel() { Name = "GgCircle", Code = "\uf261", Code_XML = "&#xf261" });
            r.Add(new FontAwesomeModel() { Name = "Ghost", Code = "\uf6e2", Code_XML = "&#xf6e2" });
            r.Add(new FontAwesomeModel() { Name = "Gift", Code = "\uf06b", Code_XML = "&#xf06b" });
            r.Add(new FontAwesomeModel() { Name = "GiftCard", Code = "\uf663", Code_XML = "&#xf663" });
            r.Add(new FontAwesomeModel() { Name = "Git", Code = "\uf1d3", Code_XML = "&#xf1d3" });
            r.Add(new FontAwesomeModel() { Name = "GitSquare", Code = "\uf1d2", Code_XML = "&#xf1d2" });
            r.Add(new FontAwesomeModel() { Name = "Github", Code = "\uf09b", Code_XML = "&#xf09b" });
            r.Add(new FontAwesomeModel() { Name = "GithubAlt", Code = "\uf113", Code_XML = "&#xf113" });
            r.Add(new FontAwesomeModel() { Name = "GithubSquare", Code = "\uf092", Code_XML = "&#xf092" });
            r.Add(new FontAwesomeModel() { Name = "Gitkraken", Code = "\uf3a6", Code_XML = "&#xf3a6" });
            r.Add(new FontAwesomeModel() { Name = "Gitlab", Code = "\uf296", Code_XML = "&#xf296" });
            r.Add(new FontAwesomeModel() { Name = "Gitter", Code = "\uf426", Code_XML = "&#xf426" });
            r.Add(new FontAwesomeModel() { Name = "GlassMartini", Code = "\uf000", Code_XML = "&#xf000" });
            r.Add(new FontAwesomeModel() { Name = "GlassMartiniAlt", Code = "\uf57b", Code_XML = "&#xf57b" });
            r.Add(new FontAwesomeModel() { Name = "Glasses", Code = "\uf530", Code_XML = "&#xf530" });
            r.Add(new FontAwesomeModel() { Name = "GlassesAlt", Code = "\uf5f5", Code_XML = "&#xf5f5" });
            r.Add(new FontAwesomeModel() { Name = "Glide", Code = "\uf2a5", Code_XML = "&#xf2a5" });
            r.Add(new FontAwesomeModel() { Name = "GlideG", Code = "\uf2a6", Code_XML = "&#xf2a6" });
            r.Add(new FontAwesomeModel() { Name = "Globe", Code = "\uf0ac", Code_XML = "&#xf0ac" });
            r.Add(new FontAwesomeModel() { Name = "GlobeAfrica", Code = "\uf57c", Code_XML = "&#xf57c" });
            r.Add(new FontAwesomeModel() { Name = "GlobeAmericas", Code = "\uf57d", Code_XML = "&#xf57d" });
            r.Add(new FontAwesomeModel() { Name = "GlobeAsia", Code = "\uf57e", Code_XML = "&#xf57e" });
            r.Add(new FontAwesomeModel() { Name = "GlobeStand", Code = "\uf5f6", Code_XML = "&#xf5f6" });
            r.Add(new FontAwesomeModel() { Name = "Gofore", Code = "\uf3a7", Code_XML = "&#xf3a7" });
            r.Add(new FontAwesomeModel() { Name = "GolfBall", Code = "\uf450", Code_XML = "&#xf450" });
            r.Add(new FontAwesomeModel() { Name = "GolfClub", Code = "\uf451", Code_XML = "&#xf451" });
            r.Add(new FontAwesomeModel() { Name = "Goodreads", Code = "\uf3a8", Code_XML = "&#xf3a8" });
            r.Add(new FontAwesomeModel() { Name = "GoodreadsG", Code = "\uf3a9", Code_XML = "&#xf3a9" });
            r.Add(new FontAwesomeModel() { Name = "Google", Code = "\uf1a0", Code_XML = "&#xf1a0" });
            r.Add(new FontAwesomeModel() { Name = "GoogleDrive", Code = "\uf3aa", Code_XML = "&#xf3aa" });
            r.Add(new FontAwesomeModel() { Name = "GooglePlay", Code = "\uf3ab", Code_XML = "&#xf3ab" });
            r.Add(new FontAwesomeModel() { Name = "GooglePlus", Code = "\uf2b3", Code_XML = "&#xf2b3" });
            r.Add(new FontAwesomeModel() { Name = "GooglePlusG", Code = "\uf0d5", Code_XML = "&#xf0d5" });
            r.Add(new FontAwesomeModel() { Name = "GooglePlusSquare", Code = "\uf0d4", Code_XML = "&#xf0d4" });
            r.Add(new FontAwesomeModel() { Name = "GoogleWallet", Code = "\uf1ee", Code_XML = "&#xf1ee" });
            r.Add(new FontAwesomeModel() { Name = "Gopuram", Code = "\uf664", Code_XML = "&#xf664" });
            r.Add(new FontAwesomeModel() { Name = "GraduationCap", Code = "\uf19d", Code_XML = "&#xf19d" });
            r.Add(new FontAwesomeModel() { Name = "Gratipay", Code = "\uf184", Code_XML = "&#xf184" });
            r.Add(new FontAwesomeModel() { Name = "Grav", Code = "\uf2d6", Code_XML = "&#xf2d6" });
            r.Add(new FontAwesomeModel() { Name = "GreaterThan", Code = "\uf531", Code_XML = "&#xf531" });
            r.Add(new FontAwesomeModel() { Name = "GreaterThanEqual", Code = "\uf532", Code_XML = "&#xf532" });
            r.Add(new FontAwesomeModel() { Name = "Grimace", Code = "\uf57f", Code_XML = "&#xf57f" });
            r.Add(new FontAwesomeModel() { Name = "Grin", Code = "\uf580", Code_XML = "&#xf580" });
            r.Add(new FontAwesomeModel() { Name = "GrinAlt", Code = "\uf581", Code_XML = "&#xf581" });
            r.Add(new FontAwesomeModel() { Name = "GrinBeam", Code = "\uf582", Code_XML = "&#xf582" });
            r.Add(new FontAwesomeModel() { Name = "GrinBeamSweat", Code = "\uf583", Code_XML = "&#xf583" });
            r.Add(new FontAwesomeModel() { Name = "GrinHearts", Code = "\uf584", Code_XML = "&#xf584" });
            r.Add(new FontAwesomeModel() { Name = "GrinSquint", Code = "\uf585", Code_XML = "&#xf585" });
            r.Add(new FontAwesomeModel() { Name = "GrinSquintTears", Code = "\uf586", Code_XML = "&#xf586" });
            r.Add(new FontAwesomeModel() { Name = "GrinStars", Code = "\uf587", Code_XML = "&#xf587" });
            r.Add(new FontAwesomeModel() { Name = "GrinTears", Code = "\uf588", Code_XML = "&#xf588" });
            r.Add(new FontAwesomeModel() { Name = "GrinTongue", Code = "\uf589", Code_XML = "&#xf589" });
            r.Add(new FontAwesomeModel() { Name = "GrinTongueSquint", Code = "\uf58a", Code_XML = "&#xf58a" });
            r.Add(new FontAwesomeModel() { Name = "GrinTongueWink", Code = "\uf58b", Code_XML = "&#xf58b" });
            r.Add(new FontAwesomeModel() { Name = "GrinWink", Code = "\uf58c", Code_XML = "&#xf58c" });
            r.Add(new FontAwesomeModel() { Name = "GripHorizontal", Code = "\uf58d", Code_XML = "&#xf58d" });
            r.Add(new FontAwesomeModel() { Name = "GripVertical", Code = "\uf58e", Code_XML = "&#xf58e" });
            r.Add(new FontAwesomeModel() { Name = "Gripfire", Code = "\uf3ac", Code_XML = "&#xf3ac" });
            r.Add(new FontAwesomeModel() { Name = "Grunt", Code = "\uf3ad", Code_XML = "&#xf3ad" });
            r.Add(new FontAwesomeModel() { Name = "Gulp", Code = "\uf3ae", Code_XML = "&#xf3ae" });
            r.Add(new FontAwesomeModel() { Name = "HSquare", Code = "\uf0fd", Code_XML = "&#xf0fd" });
            r.Add(new FontAwesomeModel() { Name = "H1", Code = "\uf313", Code_XML = "&#xf313" });
            r.Add(new FontAwesomeModel() { Name = "H2", Code = "\uf314", Code_XML = "&#xf314" });
            r.Add(new FontAwesomeModel() { Name = "H3", Code = "\uf315", Code_XML = "&#xf315" });
            r.Add(new FontAwesomeModel() { Name = "HackerNews", Code = "\uf1d4", Code_XML = "&#xf1d4" });
            r.Add(new FontAwesomeModel() { Name = "HackerNewsSquare", Code = "\uf3af", Code_XML = "&#xf3af" });
            r.Add(new FontAwesomeModel() { Name = "Hackerrank", Code = "\uf5f7", Code_XML = "&#xf5f7" });
            r.Add(new FontAwesomeModel() { Name = "Hammer", Code = "\uf6e3", Code_XML = "&#xf6e3" });
            r.Add(new FontAwesomeModel() { Name = "HammerWar", Code = "\uf6e4", Code_XML = "&#xf6e4" });
            r.Add(new FontAwesomeModel() { Name = "Hamsa", Code = "\uf665", Code_XML = "&#xf665" });
            r.Add(new FontAwesomeModel() { Name = "HandHeart", Code = "\uf4bc", Code_XML = "&#xf4bc" });
            r.Add(new FontAwesomeModel() { Name = "HandHolding", Code = "\uf4bd", Code_XML = "&#xf4bd" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingBox", Code = "\uf47b", Code_XML = "&#xf47b" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingHeart", Code = "\uf4be", Code_XML = "&#xf4be" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingMagic", Code = "\uf6e5", Code_XML = "&#xf6e5" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingSeedling", Code = "\uf4bf", Code_XML = "&#xf4bf" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingUsd", Code = "\uf4c0", Code_XML = "&#xf4c0" });
            r.Add(new FontAwesomeModel() { Name = "HandHoldingWater", Code = "\uf4c1", Code_XML = "&#xf4c1" });
            r.Add(new FontAwesomeModel() { Name = "HandLizard", Code = "\uf258", Code_XML = "&#xf258" });
            r.Add(new FontAwesomeModel() { Name = "HandPaper", Code = "\uf256", Code_XML = "&#xf256" });
            r.Add(new FontAwesomeModel() { Name = "HandPeace", Code = "\uf25b", Code_XML = "&#xf25b" });
            r.Add(new FontAwesomeModel() { Name = "HandPointDown", Code = "\uf0a7", Code_XML = "&#xf0a7" });
            r.Add(new FontAwesomeModel() { Name = "HandPointLeft", Code = "\uf0a5", Code_XML = "&#xf0a5" });
            r.Add(new FontAwesomeModel() { Name = "HandPointRight", Code = "\uf0a4", Code_XML = "&#xf0a4" });
            r.Add(new FontAwesomeModel() { Name = "HandPointUp", Code = "\uf0a6", Code_XML = "&#xf0a6" });
            r.Add(new FontAwesomeModel() { Name = "HandPointer", Code = "\uf25a", Code_XML = "&#xf25a" });
            r.Add(new FontAwesomeModel() { Name = "HandReceiving", Code = "\uf47c", Code_XML = "&#xf47c" });
            r.Add(new FontAwesomeModel() { Name = "HandRock", Code = "\uf255", Code_XML = "&#xf255" });
            r.Add(new FontAwesomeModel() { Name = "HandScissors", Code = "\uf257", Code_XML = "&#xf257" });
            r.Add(new FontAwesomeModel() { Name = "HandSpock", Code = "\uf259", Code_XML = "&#xf259" });
            r.Add(new FontAwesomeModel() { Name = "Hands", Code = "\uf4c2", Code_XML = "&#xf4c2" });
            r.Add(new FontAwesomeModel() { Name = "HandsHeart", Code = "\uf4c3", Code_XML = "&#xf4c3" });
            r.Add(new FontAwesomeModel() { Name = "HandsHelping", Code = "\uf4c4", Code_XML = "&#xf4c4" });
            r.Add(new FontAwesomeModel() { Name = "HandsUsd", Code = "\uf4c5", Code_XML = "&#xf4c5" });
            r.Add(new FontAwesomeModel() { Name = "Handshake", Code = "\uf2b5", Code_XML = "&#xf2b5" });
            r.Add(new FontAwesomeModel() { Name = "HandshakeAlt", Code = "\uf4c6", Code_XML = "&#xf4c6" });
            r.Add(new FontAwesomeModel() { Name = "Hanukiah", Code = "\uf6e6", Code_XML = "&#xf6e6" });
            r.Add(new FontAwesomeModel() { Name = "Hashtag", Code = "\uf292", Code_XML = "&#xf292" });
            r.Add(new FontAwesomeModel() { Name = "HatWitch", Code = "\uf6e7", Code_XML = "&#xf6e7" });
            r.Add(new FontAwesomeModel() { Name = "HatWizard", Code = "\uf6e8", Code_XML = "&#xf6e8" });
            r.Add(new FontAwesomeModel() { Name = "Haykal", Code = "\uf666", Code_XML = "&#xf666" });
            r.Add(new FontAwesomeModel() { Name = "Hdd", Code = "\uf0a0", Code_XML = "&#xf0a0" });
            r.Add(new FontAwesomeModel() { Name = "HeadSide", Code = "\uf6e9", Code_XML = "&#xf6e9" });
            r.Add(new FontAwesomeModel() { Name = "HeadVr", Code = "\uf6ea", Code_XML = "&#xf6ea" });
            r.Add(new FontAwesomeModel() { Name = "Heading", Code = "\uf1dc", Code_XML = "&#xf1dc" });
            r.Add(new FontAwesomeModel() { Name = "Headphones", Code = "\uf025", Code_XML = "&#xf025" });
            r.Add(new FontAwesomeModel() { Name = "HeadphonesAlt", Code = "\uf58f", Code_XML = "&#xf58f" });
            r.Add(new FontAwesomeModel() { Name = "Headset", Code = "\uf590", Code_XML = "&#xf590" });
            r.Add(new FontAwesomeModel() { Name = "Heart", Code = "\uf004", Code_XML = "&#xf004" });
            r.Add(new FontAwesomeModel() { Name = "HeartCircle", Code = "\uf4c7", Code_XML = "&#xf4c7" });
            r.Add(new FontAwesomeModel() { Name = "HeartRate", Code = "\uf5f8", Code_XML = "&#xf5f8" });
            r.Add(new FontAwesomeModel() { Name = "HeartSquare", Code = "\uf4c8", Code_XML = "&#xf4c8" });
            r.Add(new FontAwesomeModel() { Name = "Heartbeat", Code = "\uf21e", Code_XML = "&#xf21e" });
            r.Add(new FontAwesomeModel() { Name = "Helicopter", Code = "\uf533", Code_XML = "&#xf533" });
            r.Add(new FontAwesomeModel() { Name = "HelmetBattle", Code = "\uf6eb", Code_XML = "&#xf6eb" });
            r.Add(new FontAwesomeModel() { Name = "Hexagon", Code = "\uf312", Code_XML = "&#xf312" });
            r.Add(new FontAwesomeModel() { Name = "Highlighter", Code = "\uf591", Code_XML = "&#xf591" });
            r.Add(new FontAwesomeModel() { Name = "Hiking", Code = "\uf6ec", Code_XML = "&#xf6ec" });
            r.Add(new FontAwesomeModel() { Name = "Hippo", Code = "\uf6ed", Code_XML = "&#xf6ed" });
            r.Add(new FontAwesomeModel() { Name = "Hips", Code = "\uf452", Code_XML = "&#xf452" });
            r.Add(new FontAwesomeModel() { Name = "HireAHelper", Code = "\uf3b0", Code_XML = "&#xf3b0" });
            r.Add(new FontAwesomeModel() { Name = "History", Code = "\uf1da", Code_XML = "&#xf1da" });
            r.Add(new FontAwesomeModel() { Name = "HockeyMask", Code = "\uf6ee", Code_XML = "&#xf6ee" });
            r.Add(new FontAwesomeModel() { Name = "HockeyPuck", Code = "\uf453", Code_XML = "&#xf453" });
            r.Add(new FontAwesomeModel() { Name = "HockeySticks", Code = "\uf454", Code_XML = "&#xf454" });
            r.Add(new FontAwesomeModel() { Name = "Home", Code = "\uf015", Code_XML = "&#xf015" });
            r.Add(new FontAwesomeModel() { Name = "HomeHeart", Code = "\uf4c9", Code_XML = "&#xf4c9" });
            r.Add(new FontAwesomeModel() { Name = "HoodCloak", Code = "\uf6ef", Code_XML = "&#xf6ef" });
            r.Add(new FontAwesomeModel() { Name = "Hooli", Code = "\uf427", Code_XML = "&#xf427" });
            r.Add(new FontAwesomeModel() { Name = "Hornbill", Code = "\uf592", Code_XML = "&#xf592" });
            r.Add(new FontAwesomeModel() { Name = "Horse", Code = "\uf6f0", Code_XML = "&#xf6f0" });
            r.Add(new FontAwesomeModel() { Name = "Hospital", Code = "\uf0f8", Code_XML = "&#xf0f8" });
            r.Add(new FontAwesomeModel() { Name = "HospitalAlt", Code = "\uf47d", Code_XML = "&#xf47d" });
            r.Add(new FontAwesomeModel() { Name = "HospitalSymbol", Code = "\uf47e", Code_XML = "&#xf47e" });
            r.Add(new FontAwesomeModel() { Name = "HotTub", Code = "\uf593", Code_XML = "&#xf593" });
            r.Add(new FontAwesomeModel() { Name = "Hotel", Code = "\uf594", Code_XML = "&#xf594" });
            r.Add(new FontAwesomeModel() { Name = "Hotjar", Code = "\uf3b1", Code_XML = "&#xf3b1" });
            r.Add(new FontAwesomeModel() { Name = "Hourglass", Code = "\uf254", Code_XML = "&#xf254" });
            r.Add(new FontAwesomeModel() { Name = "HourglassEnd", Code = "\uf253", Code_XML = "&#xf253" });
            r.Add(new FontAwesomeModel() { Name = "HourglassHalf", Code = "\uf252", Code_XML = "&#xf252" });
            r.Add(new FontAwesomeModel() { Name = "HourglassStart", Code = "\uf251", Code_XML = "&#xf251" });
            r.Add(new FontAwesomeModel() { Name = "HouseDamage", Code = "\uf6f1", Code_XML = "&#xf6f1" });
            r.Add(new FontAwesomeModel() { Name = "HouseFlood", Code = "\uf74f", Code_XML = "&#xf74f" });
            r.Add(new FontAwesomeModel() { Name = "Houzz", Code = "\uf27c", Code_XML = "&#xf27c" });
            r.Add(new FontAwesomeModel() { Name = "Hryvnia", Code = "\uf6f2", Code_XML = "&#xf6f2" });
            r.Add(new FontAwesomeModel() { Name = "Html5", Code = "\uf13b", Code_XML = "&#xf13b" });
            r.Add(new FontAwesomeModel() { Name = "Hubspot", Code = "\uf3b2", Code_XML = "&#xf3b2" });
            r.Add(new FontAwesomeModel() { Name = "Humidity", Code = "\uf750", Code_XML = "&#xf750" });
            r.Add(new FontAwesomeModel() { Name = "Hurricane", Code = "\uf751", Code_XML = "&#xf751" });
            r.Add(new FontAwesomeModel() { Name = "ICursor", Code = "\uf246", Code_XML = "&#xf246" });
            r.Add(new FontAwesomeModel() { Name = "IdBadge", Code = "\uf2c1", Code_XML = "&#xf2c1" });
            r.Add(new FontAwesomeModel() { Name = "IdCard", Code = "\uf2c2", Code_XML = "&#xf2c2" });
            r.Add(new FontAwesomeModel() { Name = "IdCardAlt", Code = "\uf47f", Code_XML = "&#xf47f" });
            r.Add(new FontAwesomeModel() { Name = "Image", Code = "\uf03e", Code_XML = "&#xf03e" });
            r.Add(new FontAwesomeModel() { Name = "Images", Code = "\uf302", Code_XML = "&#xf302" });
            r.Add(new FontAwesomeModel() { Name = "Imdb", Code = "\uf2d8", Code_XML = "&#xf2d8" });
            r.Add(new FontAwesomeModel() { Name = "Inbox", Code = "\uf01c", Code_XML = "&#xf01c" });
            r.Add(new FontAwesomeModel() { Name = "InboxIn", Code = "\uf310", Code_XML = "&#xf310" });
            r.Add(new FontAwesomeModel() { Name = "InboxOut", Code = "\uf311", Code_XML = "&#xf311" });
            r.Add(new FontAwesomeModel() { Name = "Indent", Code = "\uf03c", Code_XML = "&#xf03c" });
            r.Add(new FontAwesomeModel() { Name = "Industry", Code = "\uf275", Code_XML = "&#xf275" });
            r.Add(new FontAwesomeModel() { Name = "IndustryAlt", Code = "\uf3b3", Code_XML = "&#xf3b3" });
            r.Add(new FontAwesomeModel() { Name = "Infinity", Code = "\uf534", Code_XML = "&#xf534" });
            r.Add(new FontAwesomeModel() { Name = "Info", Code = "\uf129", Code_XML = "&#xf129" });
            r.Add(new FontAwesomeModel() { Name = "InfoCircle", Code = "\uf05a", Code_XML = "&#xf05a" });
            r.Add(new FontAwesomeModel() { Name = "InfoSquare", Code = "\uf30f", Code_XML = "&#xf30f" });
            r.Add(new FontAwesomeModel() { Name = "Inhaler", Code = "\uf5f9", Code_XML = "&#xf5f9" });
            r.Add(new FontAwesomeModel() { Name = "Instagram", Code = "\uf16d", Code_XML = "&#xf16d" });
            r.Add(new FontAwesomeModel() { Name = "Integral", Code = "\uf667", Code_XML = "&#xf667" });
            r.Add(new FontAwesomeModel() { Name = "InternetExplorer", Code = "\uf26b", Code_XML = "&#xf26b" });
            r.Add(new FontAwesomeModel() { Name = "Intersection", Code = "\uf668", Code_XML = "&#xf668" });
            r.Add(new FontAwesomeModel() { Name = "Inventory", Code = "\uf480", Code_XML = "&#xf480" });
            r.Add(new FontAwesomeModel() { Name = "Ioxhost", Code = "\uf208", Code_XML = "&#xf208" });
            r.Add(new FontAwesomeModel() { Name = "Italic", Code = "\uf033", Code_XML = "&#xf033" });
            r.Add(new FontAwesomeModel() { Name = "Itunes", Code = "\uf3b4", Code_XML = "&#xf3b4" });
            r.Add(new FontAwesomeModel() { Name = "ItunesNote", Code = "\uf3b5", Code_XML = "&#xf3b5" });
            r.Add(new FontAwesomeModel() { Name = "JackOLantern", Code = "\uf30e", Code_XML = "&#xf30e" });
            r.Add(new FontAwesomeModel() { Name = "Java", Code = "\uf4e4", Code_XML = "&#xf4e4" });
            r.Add(new FontAwesomeModel() { Name = "Jedi", Code = "\uf669", Code_XML = "&#xf669" });
            r.Add(new FontAwesomeModel() { Name = "JediOrder", Code = "\uf50e", Code_XML = "&#xf50e" });
            r.Add(new FontAwesomeModel() { Name = "Jenkins", Code = "\uf3b6", Code_XML = "&#xf3b6" });
            r.Add(new FontAwesomeModel() { Name = "Joget", Code = "\uf3b7", Code_XML = "&#xf3b7" });
            r.Add(new FontAwesomeModel() { Name = "Joint", Code = "\uf595", Code_XML = "&#xf595" });
            r.Add(new FontAwesomeModel() { Name = "Joomla", Code = "\uf1aa", Code_XML = "&#xf1aa" });
            r.Add(new FontAwesomeModel() { Name = "JournalWhills", Code = "\uf66a", Code_XML = "&#xf66a" });
            r.Add(new FontAwesomeModel() { Name = "Js", Code = "\uf3b8", Code_XML = "&#xf3b8" });
            r.Add(new FontAwesomeModel() { Name = "JsSquare", Code = "\uf3b9", Code_XML = "&#xf3b9" });
            r.Add(new FontAwesomeModel() { Name = "Jsfiddle", Code = "\uf1cc", Code_XML = "&#xf1cc" });
            r.Add(new FontAwesomeModel() { Name = "Kaaba", Code = "\uf66b", Code_XML = "&#xf66b" });
            r.Add(new FontAwesomeModel() { Name = "Kaggle", Code = "\uf5fa", Code_XML = "&#xf5fa" });
            r.Add(new FontAwesomeModel() { Name = "Key", Code = "\uf084", Code_XML = "&#xf084" });
            r.Add(new FontAwesomeModel() { Name = "KeySkeleton", Code = "\uf6f3", Code_XML = "&#xf6f3" });
            r.Add(new FontAwesomeModel() { Name = "Keybase", Code = "\uf4f5", Code_XML = "&#xf4f5" });
            r.Add(new FontAwesomeModel() { Name = "Keyboard", Code = "\uf11c", Code_XML = "&#xf11c" });
            r.Add(new FontAwesomeModel() { Name = "Keycdn", Code = "\uf3ba", Code_XML = "&#xf3ba" });
            r.Add(new FontAwesomeModel() { Name = "Keynote", Code = "\uf66c", Code_XML = "&#xf66c" });
            r.Add(new FontAwesomeModel() { Name = "Khanda", Code = "\uf66d", Code_XML = "&#xf66d" });
            r.Add(new FontAwesomeModel() { Name = "Kickstarter", Code = "\uf3bb", Code_XML = "&#xf3bb" });
            r.Add(new FontAwesomeModel() { Name = "KickstarterK", Code = "\uf3bc", Code_XML = "&#xf3bc" });
            r.Add(new FontAwesomeModel() { Name = "Kidneys", Code = "\uf5fb", Code_XML = "&#xf5fb" });
            r.Add(new FontAwesomeModel() { Name = "Kiss", Code = "\uf596", Code_XML = "&#xf596" });
            r.Add(new FontAwesomeModel() { Name = "KissBeam", Code = "\uf597", Code_XML = "&#xf597" });
            r.Add(new FontAwesomeModel() { Name = "KissWinkHeart", Code = "\uf598", Code_XML = "&#xf598" });
            r.Add(new FontAwesomeModel() { Name = "Kite", Code = "\uf6f4", Code_XML = "&#xf6f4" });
            r.Add(new FontAwesomeModel() { Name = "KiwiBird", Code = "\uf535", Code_XML = "&#xf535" });
            r.Add(new FontAwesomeModel() { Name = "KnifeKitchen", Code = "\uf6f5", Code_XML = "&#xf6f5" });
            r.Add(new FontAwesomeModel() { Name = "Korvue", Code = "\uf42f", Code_XML = "&#xf42f" });
            r.Add(new FontAwesomeModel() { Name = "Lambda", Code = "\uf66e", Code_XML = "&#xf66e" });
            r.Add(new FontAwesomeModel() { Name = "Lamp", Code = "\uf4ca", Code_XML = "&#xf4ca" });
            r.Add(new FontAwesomeModel() { Name = "Landmark", Code = "\uf66f", Code_XML = "&#xf66f" });
            r.Add(new FontAwesomeModel() { Name = "LandmarkAlt", Code = "\uf752", Code_XML = "&#xf752" });
            r.Add(new FontAwesomeModel() { Name = "Language", Code = "\uf1ab", Code_XML = "&#xf1ab" });
            r.Add(new FontAwesomeModel() { Name = "Laptop", Code = "\uf109", Code_XML = "&#xf109" });
            r.Add(new FontAwesomeModel() { Name = "LaptopCode", Code = "\uf5fc", Code_XML = "&#xf5fc" });
            r.Add(new FontAwesomeModel() { Name = "Laravel", Code = "\uf3bd", Code_XML = "&#xf3bd" });
            r.Add(new FontAwesomeModel() { Name = "Lastfm", Code = "\uf202", Code_XML = "&#xf202" });
            r.Add(new FontAwesomeModel() { Name = "LastfmSquare", Code = "\uf203", Code_XML = "&#xf203" });
            r.Add(new FontAwesomeModel() { Name = "Laugh", Code = "\uf599", Code_XML = "&#xf599" });
            r.Add(new FontAwesomeModel() { Name = "LaughBeam", Code = "\uf59a", Code_XML = "&#xf59a" });
            r.Add(new FontAwesomeModel() { Name = "LaughSquint", Code = "\uf59b", Code_XML = "&#xf59b" });
            r.Add(new FontAwesomeModel() { Name = "LaughWink", Code = "\uf59c", Code_XML = "&#xf59c" });
            r.Add(new FontAwesomeModel() { Name = "LayerGroup", Code = "\uf5fd", Code_XML = "&#xf5fd" });
            r.Add(new FontAwesomeModel() { Name = "LayerMinus", Code = "\uf5fe", Code_XML = "&#xf5fe" });
            r.Add(new FontAwesomeModel() { Name = "LayerPlus", Code = "\uf5ff", Code_XML = "&#xf5ff" });
            r.Add(new FontAwesomeModel() { Name = "Leaf", Code = "\uf06c", Code_XML = "&#xf06c" });
            r.Add(new FontAwesomeModel() { Name = "LeafHeart", Code = "\uf4cb", Code_XML = "&#xf4cb" });
            r.Add(new FontAwesomeModel() { Name = "LeafMaple", Code = "\uf6f6", Code_XML = "&#xf6f6" });
            r.Add(new FontAwesomeModel() { Name = "LeafOak", Code = "\uf6f7", Code_XML = "&#xf6f7" });
            r.Add(new FontAwesomeModel() { Name = "Leanpub", Code = "\uf212", Code_XML = "&#xf212" });
            r.Add(new FontAwesomeModel() { Name = "Lemon", Code = "\uf094", Code_XML = "&#xf094" });
            r.Add(new FontAwesomeModel() { Name = "Less", Code = "\uf41d", Code_XML = "&#xf41d" });
            r.Add(new FontAwesomeModel() { Name = "LessThan", Code = "\uf536", Code_XML = "&#xf536" });
            r.Add(new FontAwesomeModel() { Name = "LessThanEqual", Code = "\uf537", Code_XML = "&#xf537" });
            r.Add(new FontAwesomeModel() { Name = "LevelDown", Code = "\uf149", Code_XML = "&#xf149" });
            r.Add(new FontAwesomeModel() { Name = "LevelDownAlt", Code = "\uf3be", Code_XML = "&#xf3be" });
            r.Add(new FontAwesomeModel() { Name = "LevelUp", Code = "\uf148", Code_XML = "&#xf148" });
            r.Add(new FontAwesomeModel() { Name = "LevelUpAlt", Code = "\uf3bf", Code_XML = "&#xf3bf" });
            r.Add(new FontAwesomeModel() { Name = "LifeRing", Code = "\uf1cd", Code_XML = "&#xf1cd" });
            r.Add(new FontAwesomeModel() { Name = "Lightbulb", Code = "\uf0eb", Code_XML = "&#xf0eb" });
            r.Add(new FontAwesomeModel() { Name = "LightbulbDollar", Code = "\uf670", Code_XML = "&#xf670" });
            r.Add(new FontAwesomeModel() { Name = "LightbulbExclamation", Code = "\uf671", Code_XML = "&#xf671" });
            r.Add(new FontAwesomeModel() { Name = "LightbulbOn", Code = "\uf672", Code_XML = "&#xf672" });
            r.Add(new FontAwesomeModel() { Name = "LightbulbSlash", Code = "\uf673", Code_XML = "&#xf673" });
            r.Add(new FontAwesomeModel() { Name = "Line", Code = "\uf3c0", Code_XML = "&#xf3c0" });
            r.Add(new FontAwesomeModel() { Name = "Link", Code = "\uf0c1", Code_XML = "&#xf0c1" });
            r.Add(new FontAwesomeModel() { Name = "Linkedin", Code = "\uf08c", Code_XML = "&#xf08c" });
            r.Add(new FontAwesomeModel() { Name = "LinkedinIn", Code = "\uf0e1", Code_XML = "&#xf0e1" });
            r.Add(new FontAwesomeModel() { Name = "Linode", Code = "\uf2b8", Code_XML = "&#xf2b8" });
            r.Add(new FontAwesomeModel() { Name = "Linux", Code = "\uf17c", Code_XML = "&#xf17c" });
            r.Add(new FontAwesomeModel() { Name = "Lips", Code = "\uf600", Code_XML = "&#xf600" });
            r.Add(new FontAwesomeModel() { Name = "LiraSign", Code = "\uf195", Code_XML = "&#xf195" });
            r.Add(new FontAwesomeModel() { Name = "List", Code = "\uf03a", Code_XML = "&#xf03a" });
            r.Add(new FontAwesomeModel() { Name = "ListAlt", Code = "\uf022", Code_XML = "&#xf022" });
            r.Add(new FontAwesomeModel() { Name = "ListOl", Code = "\uf0cb", Code_XML = "&#xf0cb" });
            r.Add(new FontAwesomeModel() { Name = "ListUl", Code = "\uf0ca", Code_XML = "&#xf0ca" });
            r.Add(new FontAwesomeModel() { Name = "Location", Code = "\uf601", Code_XML = "&#xf601" });
            r.Add(new FontAwesomeModel() { Name = "LocationArrow", Code = "\uf124", Code_XML = "&#xf124" });
            r.Add(new FontAwesomeModel() { Name = "LocationCircle", Code = "\uf602", Code_XML = "&#xf602" });
            r.Add(new FontAwesomeModel() { Name = "LocationSlash", Code = "\uf603", Code_XML = "&#xf603" });
            r.Add(new FontAwesomeModel() { Name = "Lock", Code = "\uf023", Code_XML = "&#xf023" });
            r.Add(new FontAwesomeModel() { Name = "LockAlt", Code = "\uf30d", Code_XML = "&#xf30d" });
            r.Add(new FontAwesomeModel() { Name = "LockOpen", Code = "\uf3c1", Code_XML = "&#xf3c1" });
            r.Add(new FontAwesomeModel() { Name = "LockOpenAlt", Code = "\uf3c2", Code_XML = "&#xf3c2" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowAltDown", Code = "\uf309", Code_XML = "&#xf309" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowAltLeft", Code = "\uf30a", Code_XML = "&#xf30a" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowAltRight", Code = "\uf30b", Code_XML = "&#xf30b" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowAltUp", Code = "\uf30c", Code_XML = "&#xf30c" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowDown", Code = "\uf175", Code_XML = "&#xf175" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowLeft", Code = "\uf177", Code_XML = "&#xf177" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowRight", Code = "\uf178", Code_XML = "&#xf178" });
            r.Add(new FontAwesomeModel() { Name = "LongArrowUp", Code = "\uf176", Code_XML = "&#xf176" });
            r.Add(new FontAwesomeModel() { Name = "Loveseat", Code = "\uf4cc", Code_XML = "&#xf4cc" });
            r.Add(new FontAwesomeModel() { Name = "LowVision", Code = "\uf2a8", Code_XML = "&#xf2a8" });
            r.Add(new FontAwesomeModel() { Name = "Luchador", Code = "\uf455", Code_XML = "&#xf455" });
            r.Add(new FontAwesomeModel() { Name = "LuggageCart", Code = "\uf59d", Code_XML = "&#xf59d" });
            r.Add(new FontAwesomeModel() { Name = "Lungs", Code = "\uf604", Code_XML = "&#xf604" });
            r.Add(new FontAwesomeModel() { Name = "Lyft", Code = "\uf3c3", Code_XML = "&#xf3c3" });
            r.Add(new FontAwesomeModel() { Name = "Mace", Code = "\uf6f8", Code_XML = "&#xf6f8" });
            r.Add(new FontAwesomeModel() { Name = "Magento", Code = "\uf3c4", Code_XML = "&#xf3c4" });
            r.Add(new FontAwesomeModel() { Name = "Magic", Code = "\uf0d0", Code_XML = "&#xf0d0" });
            r.Add(new FontAwesomeModel() { Name = "Magnet", Code = "\uf076", Code_XML = "&#xf076" });
            r.Add(new FontAwesomeModel() { Name = "MailBulk", Code = "\uf674", Code_XML = "&#xf674" });
            r.Add(new FontAwesomeModel() { Name = "Mailchimp", Code = "\uf59e", Code_XML = "&#xf59e" });
            r.Add(new FontAwesomeModel() { Name = "Male", Code = "\uf183", Code_XML = "&#xf183" });
            r.Add(new FontAwesomeModel() { Name = "Mandalorian", Code = "\uf50f", Code_XML = "&#xf50f" });
            r.Add(new FontAwesomeModel() { Name = "Mandolin", Code = "\uf6f9", Code_XML = "&#xf6f9" });
            r.Add(new FontAwesomeModel() { Name = "Map", Code = "\uf279", Code_XML = "&#xf279" });
            r.Add(new FontAwesomeModel() { Name = "MapMarked", Code = "\uf59f", Code_XML = "&#xf59f" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkedAlt", Code = "\uf5a0", Code_XML = "&#xf5a0" });
            r.Add(new FontAwesomeModel() { Name = "MapMarker", Code = "\uf041", Code_XML = "&#xf041" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerAlt", Code = "\uf3c5", Code_XML = "&#xf3c5" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerAltSlash", Code = "\uf605", Code_XML = "&#xf605" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerCheck", Code = "\uf606", Code_XML = "&#xf606" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerEdit", Code = "\uf607", Code_XML = "&#xf607" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerExclamation", Code = "\uf608", Code_XML = "&#xf608" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerMinus", Code = "\uf609", Code_XML = "&#xf609" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerPlus", Code = "\uf60a", Code_XML = "&#xf60a" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerQuestion", Code = "\uf60b", Code_XML = "&#xf60b" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerSlash", Code = "\uf60c", Code_XML = "&#xf60c" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerSmile", Code = "\uf60d", Code_XML = "&#xf60d" });
            r.Add(new FontAwesomeModel() { Name = "MapMarkerTimes", Code = "\uf60e", Code_XML = "&#xf60e" });
            r.Add(new FontAwesomeModel() { Name = "MapPin", Code = "\uf276", Code_XML = "&#xf276" });
            r.Add(new FontAwesomeModel() { Name = "MapSigns", Code = "\uf277", Code_XML = "&#xf277" });
            r.Add(new FontAwesomeModel() { Name = "Markdown", Code = "\uf60f", Code_XML = "&#xf60f" });
            r.Add(new FontAwesomeModel() { Name = "Marker", Code = "\uf5a1", Code_XML = "&#xf5a1" });
            r.Add(new FontAwesomeModel() { Name = "Mars", Code = "\uf222", Code_XML = "&#xf222" });
            r.Add(new FontAwesomeModel() { Name = "MarsDouble", Code = "\uf227", Code_XML = "&#xf227" });
            r.Add(new FontAwesomeModel() { Name = "MarsStroke", Code = "\uf229", Code_XML = "&#xf229" });
            r.Add(new FontAwesomeModel() { Name = "MarsStrokeH", Code = "\uf22b", Code_XML = "&#xf22b" });
            r.Add(new FontAwesomeModel() { Name = "MarsStrokeV", Code = "\uf22a", Code_XML = "&#xf22a" });
            r.Add(new FontAwesomeModel() { Name = "Mask", Code = "\uf6fa", Code_XML = "&#xf6fa" });
            r.Add(new FontAwesomeModel() { Name = "Mastodon", Code = "\uf4f6", Code_XML = "&#xf4f6" });
            r.Add(new FontAwesomeModel() { Name = "Maxcdn", Code = "\uf136", Code_XML = "&#xf136" });
            r.Add(new FontAwesomeModel() { Name = "Medal", Code = "\uf5a2", Code_XML = "&#xf5a2" });
            r.Add(new FontAwesomeModel() { Name = "Medapps", Code = "\uf3c6", Code_XML = "&#xf3c6" });
            r.Add(new FontAwesomeModel() { Name = "Medium", Code = "\uf23a", Code_XML = "&#xf23a" });
            r.Add(new FontAwesomeModel() { Name = "MediumM", Code = "\uf3c7", Code_XML = "&#xf3c7" });
            r.Add(new FontAwesomeModel() { Name = "Medkit", Code = "\uf0fa", Code_XML = "&#xf0fa" });
            r.Add(new FontAwesomeModel() { Name = "Medrt", Code = "\uf3c8", Code_XML = "&#xf3c8" });
            r.Add(new FontAwesomeModel() { Name = "Meetup", Code = "\uf2e0", Code_XML = "&#xf2e0" });
            r.Add(new FontAwesomeModel() { Name = "Megaphone", Code = "\uf675", Code_XML = "&#xf675" });
            r.Add(new FontAwesomeModel() { Name = "Megaport", Code = "\uf5a3", Code_XML = "&#xf5a3" });
            r.Add(new FontAwesomeModel() { Name = "Meh", Code = "\uf11a", Code_XML = "&#xf11a" });
            r.Add(new FontAwesomeModel() { Name = "MehBlank", Code = "\uf5a4", Code_XML = "&#xf5a4" });
            r.Add(new FontAwesomeModel() { Name = "MehRollingEyes", Code = "\uf5a5", Code_XML = "&#xf5a5" });
            r.Add(new FontAwesomeModel() { Name = "Memory", Code = "\uf538", Code_XML = "&#xf538" });
            r.Add(new FontAwesomeModel() { Name = "Menorah", Code = "\uf676", Code_XML = "&#xf676" });
            r.Add(new FontAwesomeModel() { Name = "Mercury", Code = "\uf223", Code_XML = "&#xf223" });
            r.Add(new FontAwesomeModel() { Name = "Meteor", Code = "\uf753", Code_XML = "&#xf753" });
            r.Add(new FontAwesomeModel() { Name = "Microchip", Code = "\uf2db", Code_XML = "&#xf2db" });
            r.Add(new FontAwesomeModel() { Name = "Microphone", Code = "\uf130", Code_XML = "&#xf130" });
            r.Add(new FontAwesomeModel() { Name = "MicrophoneAlt", Code = "\uf3c9", Code_XML = "&#xf3c9" });
            r.Add(new FontAwesomeModel() { Name = "MicrophoneAltSlash", Code = "\uf539", Code_XML = "&#xf539" });
            r.Add(new FontAwesomeModel() { Name = "MicrophoneSlash", Code = "\uf131", Code_XML = "&#xf131" });
            r.Add(new FontAwesomeModel() { Name = "Microscope", Code = "\uf610", Code_XML = "&#xf610" });
            r.Add(new FontAwesomeModel() { Name = "Microsoft", Code = "\uf3ca", Code_XML = "&#xf3ca" });
            r.Add(new FontAwesomeModel() { Name = "MindShare", Code = "\uf677", Code_XML = "&#xf677" });
            r.Add(new FontAwesomeModel() { Name = "Minus", Code = "\uf068", Code_XML = "&#xf068" });
            r.Add(new FontAwesomeModel() { Name = "MinusCircle", Code = "\uf056", Code_XML = "&#xf056" });
            r.Add(new FontAwesomeModel() { Name = "MinusHexagon", Code = "\uf307", Code_XML = "&#xf307" });
            r.Add(new FontAwesomeModel() { Name = "MinusOctagon", Code = "\uf308", Code_XML = "&#xf308" });
            r.Add(new FontAwesomeModel() { Name = "MinusSquare", Code = "\uf146", Code_XML = "&#xf146" });
            r.Add(new FontAwesomeModel() { Name = "Mix", Code = "\uf3cb", Code_XML = "&#xf3cb" });
            r.Add(new FontAwesomeModel() { Name = "Mixcloud", Code = "\uf289", Code_XML = "&#xf289" });
            r.Add(new FontAwesomeModel() { Name = "Mizuni", Code = "\uf3cc", Code_XML = "&#xf3cc" });
            r.Add(new FontAwesomeModel() { Name = "Mobile", Code = "\uf10b", Code_XML = "&#xf10b" });
            r.Add(new FontAwesomeModel() { Name = "MobileAlt", Code = "\uf3cd", Code_XML = "&#xf3cd" });
            r.Add(new FontAwesomeModel() { Name = "MobileAndroid", Code = "\uf3ce", Code_XML = "&#xf3ce" });
            r.Add(new FontAwesomeModel() { Name = "MobileAndroidAlt", Code = "\uf3cf", Code_XML = "&#xf3cf" });
            r.Add(new FontAwesomeModel() { Name = "Modx", Code = "\uf285", Code_XML = "&#xf285" });
            r.Add(new FontAwesomeModel() { Name = "Monero", Code = "\uf3d0", Code_XML = "&#xf3d0" });
            r.Add(new FontAwesomeModel() { Name = "MoneyBill", Code = "\uf0d6", Code_XML = "&#xf0d6" });
            r.Add(new FontAwesomeModel() { Name = "MoneyBillAlt", Code = "\uf3d1", Code_XML = "&#xf3d1" });
            r.Add(new FontAwesomeModel() { Name = "MoneyBillWave", Code = "\uf53a", Code_XML = "&#xf53a" });
            r.Add(new FontAwesomeModel() { Name = "MoneyBillWaveAlt", Code = "\uf53b", Code_XML = "&#xf53b" });
            r.Add(new FontAwesomeModel() { Name = "MoneyCheck", Code = "\uf53c", Code_XML = "&#xf53c" });
            r.Add(new FontAwesomeModel() { Name = "MoneyCheckAlt", Code = "\uf53d", Code_XML = "&#xf53d" });
            r.Add(new FontAwesomeModel() { Name = "MonitorHeartRate", Code = "\uf611", Code_XML = "&#xf611" });
            r.Add(new FontAwesomeModel() { Name = "Monkey", Code = "\uf6fb", Code_XML = "&#xf6fb" });
            r.Add(new FontAwesomeModel() { Name = "Monument", Code = "\uf5a6", Code_XML = "&#xf5a6" });
            r.Add(new FontAwesomeModel() { Name = "Moon", Code = "\uf186", Code_XML = "&#xf186" });
            r.Add(new FontAwesomeModel() { Name = "MoonCloud", Code = "\uf754", Code_XML = "&#xf754" });
            r.Add(new FontAwesomeModel() { Name = "MoonStars", Code = "\uf755", Code_XML = "&#xf755" });
            r.Add(new FontAwesomeModel() { Name = "MortarPestle", Code = "\uf5a7", Code_XML = "&#xf5a7" });
            r.Add(new FontAwesomeModel() { Name = "Mosque", Code = "\uf678", Code_XML = "&#xf678" });
            r.Add(new FontAwesomeModel() { Name = "Motorcycle", Code = "\uf21c", Code_XML = "&#xf21c" });
            r.Add(new FontAwesomeModel() { Name = "Mountain", Code = "\uf6fc", Code_XML = "&#xf6fc" });
            r.Add(new FontAwesomeModel() { Name = "Mountains", Code = "\uf6fd", Code_XML = "&#xf6fd" });
            r.Add(new FontAwesomeModel() { Name = "MousePointer", Code = "\uf245", Code_XML = "&#xf245" });
            r.Add(new FontAwesomeModel() { Name = "Music", Code = "\uf001", Code_XML = "&#xf001" });
            r.Add(new FontAwesomeModel() { Name = "Napster", Code = "\uf3d2", Code_XML = "&#xf3d2" });
            r.Add(new FontAwesomeModel() { Name = "Narwhal", Code = "\uf6fe", Code_XML = "&#xf6fe" });
            r.Add(new FontAwesomeModel() { Name = "Neos", Code = "\uf612", Code_XML = "&#xf612" });
            r.Add(new FontAwesomeModel() { Name = "NetworkWired", Code = "\uf6ff", Code_XML = "&#xf6ff" });
            r.Add(new FontAwesomeModel() { Name = "Neuter", Code = "\uf22c", Code_XML = "&#xf22c" });
            r.Add(new FontAwesomeModel() { Name = "Newspaper", Code = "\uf1ea", Code_XML = "&#xf1ea" });
            r.Add(new FontAwesomeModel() { Name = "Nimblr", Code = "\uf5a8", Code_XML = "&#xf5a8" });
            r.Add(new FontAwesomeModel() { Name = "NintendoSwitch", Code = "\uf418", Code_XML = "&#xf418" });
            r.Add(new FontAwesomeModel() { Name = "Node", Code = "\uf419", Code_XML = "&#xf419" });
            r.Add(new FontAwesomeModel() { Name = "NodeJs", Code = "\uf3d3", Code_XML = "&#xf3d3" });
            r.Add(new FontAwesomeModel() { Name = "NotEqual", Code = "\uf53e", Code_XML = "&#xf53e" });
            r.Add(new FontAwesomeModel() { Name = "NotesMedical", Code = "\uf481", Code_XML = "&#xf481" });
            r.Add(new FontAwesomeModel() { Name = "Npm", Code = "\uf3d4", Code_XML = "&#xf3d4" });
            r.Add(new FontAwesomeModel() { Name = "Ns8", Code = "\uf3d5", Code_XML = "&#xf3d5" });
            r.Add(new FontAwesomeModel() { Name = "Nutritionix", Code = "\uf3d6", Code_XML = "&#xf3d6" });
            r.Add(new FontAwesomeModel() { Name = "ObjectGroup", Code = "\uf247", Code_XML = "&#xf247" });
            r.Add(new FontAwesomeModel() { Name = "ObjectUngroup", Code = "\uf248", Code_XML = "&#xf248" });
            r.Add(new FontAwesomeModel() { Name = "Octagon", Code = "\uf306", Code_XML = "&#xf306" });
            r.Add(new FontAwesomeModel() { Name = "Odnoklassniki", Code = "\uf263", Code_XML = "&#xf263" });
            r.Add(new FontAwesomeModel() { Name = "OdnoklassnikiSquare", Code = "\uf264", Code_XML = "&#xf264" });
            r.Add(new FontAwesomeModel() { Name = "OilCan", Code = "\uf613", Code_XML = "&#xf613" });
            r.Add(new FontAwesomeModel() { Name = "OilTemp", Code = "\uf614", Code_XML = "&#xf614" });
            r.Add(new FontAwesomeModel() { Name = "OldRepublic", Code = "\uf510", Code_XML = "&#xf510" });
            r.Add(new FontAwesomeModel() { Name = "Om", Code = "\uf679", Code_XML = "&#xf679" });
            r.Add(new FontAwesomeModel() { Name = "Omega", Code = "\uf67a", Code_XML = "&#xf67a" });
            r.Add(new FontAwesomeModel() { Name = "Opencart", Code = "\uf23d", Code_XML = "&#xf23d" });
            r.Add(new FontAwesomeModel() { Name = "Openid", Code = "\uf19b", Code_XML = "&#xf19b" });
            r.Add(new FontAwesomeModel() { Name = "Opera", Code = "\uf26a", Code_XML = "&#xf26a" });
            r.Add(new FontAwesomeModel() { Name = "OptinMonster", Code = "\uf23c", Code_XML = "&#xf23c" });
            r.Add(new FontAwesomeModel() { Name = "Osi", Code = "\uf41a", Code_XML = "&#xf41a" });
            r.Add(new FontAwesomeModel() { Name = "Otter", Code = "\uf700", Code_XML = "&#xf700" });
            r.Add(new FontAwesomeModel() { Name = "Outdent", Code = "\uf03b", Code_XML = "&#xf03b" });
            r.Add(new FontAwesomeModel() { Name = "Page4", Code = "\uf3d7", Code_XML = "&#xf3d7" });
            r.Add(new FontAwesomeModel() { Name = "Pagelines", Code = "\uf18c", Code_XML = "&#xf18c" });
            r.Add(new FontAwesomeModel() { Name = "PaintBrush", Code = "\uf1fc", Code_XML = "&#xf1fc" });
            r.Add(new FontAwesomeModel() { Name = "PaintBrushAlt", Code = "\uf5a9", Code_XML = "&#xf5a9" });
            r.Add(new FontAwesomeModel() { Name = "PaintRoller", Code = "\uf5aa", Code_XML = "&#xf5aa" });
            r.Add(new FontAwesomeModel() { Name = "Palette", Code = "\uf53f", Code_XML = "&#xf53f" });
            r.Add(new FontAwesomeModel() { Name = "Palfed", Code = "\uf3d8", Code_XML = "&#xf3d8" });
            r.Add(new FontAwesomeModel() { Name = "Pallet", Code = "\uf482", Code_XML = "&#xf482" });
            r.Add(new FontAwesomeModel() { Name = "PalletAlt", Code = "\uf483", Code_XML = "&#xf483" });
            r.Add(new FontAwesomeModel() { Name = "PaperPlane", Code = "\uf1d8", Code_XML = "&#xf1d8" });
            r.Add(new FontAwesomeModel() { Name = "Paperclip", Code = "\uf0c6", Code_XML = "&#xf0c6" });
            r.Add(new FontAwesomeModel() { Name = "ParachuteBox", Code = "\uf4cd", Code_XML = "&#xf4cd" });
            r.Add(new FontAwesomeModel() { Name = "Paragraph", Code = "\uf1dd", Code_XML = "&#xf1dd" });
            r.Add(new FontAwesomeModel() { Name = "Parking", Code = "\uf540", Code_XML = "&#xf540" });
            r.Add(new FontAwesomeModel() { Name = "ParkingCircle", Code = "\uf615", Code_XML = "&#xf615" });
            r.Add(new FontAwesomeModel() { Name = "ParkingCircleSlash", Code = "\uf616", Code_XML = "&#xf616" });
            r.Add(new FontAwesomeModel() { Name = "ParkingSlash", Code = "\uf617", Code_XML = "&#xf617" });
            r.Add(new FontAwesomeModel() { Name = "Passport", Code = "\uf5ab", Code_XML = "&#xf5ab" });
            r.Add(new FontAwesomeModel() { Name = "Pastafarianism", Code = "\uf67b", Code_XML = "&#xf67b" });
            r.Add(new FontAwesomeModel() { Name = "Paste", Code = "\uf0ea", Code_XML = "&#xf0ea" });
            r.Add(new FontAwesomeModel() { Name = "Patreon", Code = "\uf3d9", Code_XML = "&#xf3d9" });
            r.Add(new FontAwesomeModel() { Name = "Pause", Code = "\uf04c", Code_XML = "&#xf04c" });
            r.Add(new FontAwesomeModel() { Name = "PauseCircle", Code = "\uf28b", Code_XML = "&#xf28b" });
            r.Add(new FontAwesomeModel() { Name = "Paw", Code = "\uf1b0", Code_XML = "&#xf1b0" });
            r.Add(new FontAwesomeModel() { Name = "PawAlt", Code = "\uf701", Code_XML = "&#xf701" });
            r.Add(new FontAwesomeModel() { Name = "PawClaws", Code = "\uf702", Code_XML = "&#xf702" });
            r.Add(new FontAwesomeModel() { Name = "Paypal", Code = "\uf1ed", Code_XML = "&#xf1ed" });
            r.Add(new FontAwesomeModel() { Name = "Peace", Code = "\uf67c", Code_XML = "&#xf67c" });
            r.Add(new FontAwesomeModel() { Name = "Pegasus", Code = "\uf703", Code_XML = "&#xf703" });
            r.Add(new FontAwesomeModel() { Name = "Pen", Code = "\uf304", Code_XML = "&#xf304" });
            r.Add(new FontAwesomeModel() { Name = "PenAlt", Code = "\uf305", Code_XML = "&#xf305" });
            r.Add(new FontAwesomeModel() { Name = "PenFancy", Code = "\uf5ac", Code_XML = "&#xf5ac" });
            r.Add(new FontAwesomeModel() { Name = "PenNib", Code = "\uf5ad", Code_XML = "&#xf5ad" });
            r.Add(new FontAwesomeModel() { Name = "PenSquare", Code = "\uf14b", Code_XML = "&#xf14b" });
            r.Add(new FontAwesomeModel() { Name = "Pencil", Code = "\uf040", Code_XML = "&#xf040" });
            r.Add(new FontAwesomeModel() { Name = "PencilAlt", Code = "\uf303", Code_XML = "&#xf303" });
            r.Add(new FontAwesomeModel() { Name = "PencilPaintbrush", Code = "\uf618", Code_XML = "&#xf618" });
            r.Add(new FontAwesomeModel() { Name = "PencilRuler", Code = "\uf5ae", Code_XML = "&#xf5ae" });
            r.Add(new FontAwesomeModel() { Name = "Pennant", Code = "\uf456", Code_XML = "&#xf456" });
            r.Add(new FontAwesomeModel() { Name = "PennyArcade", Code = "\uf704", Code_XML = "&#xf704" });
            r.Add(new FontAwesomeModel() { Name = "PeopleCarry", Code = "\uf4ce", Code_XML = "&#xf4ce" });
            r.Add(new FontAwesomeModel() { Name = "Percent", Code = "\uf295", Code_XML = "&#xf295" });
            r.Add(new FontAwesomeModel() { Name = "Percentage", Code = "\uf541", Code_XML = "&#xf541" });
            r.Add(new FontAwesomeModel() { Name = "Periscope", Code = "\uf3da", Code_XML = "&#xf3da" });
            r.Add(new FontAwesomeModel() { Name = "PersonBooth", Code = "\uf756", Code_XML = "&#xf756" });
            r.Add(new FontAwesomeModel() { Name = "PersonCarry", Code = "\uf4cf", Code_XML = "&#xf4cf" });
            r.Add(new FontAwesomeModel() { Name = "PersonDolly", Code = "\uf4d0", Code_XML = "&#xf4d0" });
            r.Add(new FontAwesomeModel() { Name = "PersonDollyEmpty", Code = "\uf4d1", Code_XML = "&#xf4d1" });
            r.Add(new FontAwesomeModel() { Name = "PersonSign", Code = "\uf757", Code_XML = "&#xf757" });
            r.Add(new FontAwesomeModel() { Name = "Phabricator", Code = "\uf3db", Code_XML = "&#xf3db" });
            r.Add(new FontAwesomeModel() { Name = "PhoenixFramework", Code = "\uf3dc", Code_XML = "&#xf3dc" });
            r.Add(new FontAwesomeModel() { Name = "PhoenixSquadron", Code = "\uf511", Code_XML = "&#xf511" });
            r.Add(new FontAwesomeModel() { Name = "Phone", Code = "\uf095", Code_XML = "&#xf095" });
            r.Add(new FontAwesomeModel() { Name = "PhoneOffice", Code = "\uf67d", Code_XML = "&#xf67d" });
            r.Add(new FontAwesomeModel() { Name = "PhonePlus", Code = "\uf4d2", Code_XML = "&#xf4d2" });
            r.Add(new FontAwesomeModel() { Name = "PhoneSlash", Code = "\uf3dd", Code_XML = "&#xf3dd" });
            r.Add(new FontAwesomeModel() { Name = "PhoneSquare", Code = "\uf098", Code_XML = "&#xf098" });
            r.Add(new FontAwesomeModel() { Name = "PhoneVolume", Code = "\uf2a0", Code_XML = "&#xf2a0" });
            r.Add(new FontAwesomeModel() { Name = "Php", Code = "\uf457", Code_XML = "&#xf457" });
            r.Add(new FontAwesomeModel() { Name = "Pi", Code = "\uf67e", Code_XML = "&#xf67e" });
            r.Add(new FontAwesomeModel() { Name = "Pie", Code = "\uf705", Code_XML = "&#xf705" });
            r.Add(new FontAwesomeModel() { Name = "PiedPiper", Code = "\uf2ae", Code_XML = "&#xf2ae" });
            r.Add(new FontAwesomeModel() { Name = "PiedPiperAlt", Code = "\uf1a8", Code_XML = "&#xf1a8" });
            r.Add(new FontAwesomeModel() { Name = "PiedPiperHat", Code = "\uf4e5", Code_XML = "&#xf4e5" });
            r.Add(new FontAwesomeModel() { Name = "PiedPiperPp", Code = "\uf1a7", Code_XML = "&#xf1a7" });
            r.Add(new FontAwesomeModel() { Name = "Pig", Code = "\uf706", Code_XML = "&#xf706" });
            r.Add(new FontAwesomeModel() { Name = "PiggyBank", Code = "\uf4d3", Code_XML = "&#xf4d3" });
            r.Add(new FontAwesomeModel() { Name = "Pills", Code = "\uf484", Code_XML = "&#xf484" });
            r.Add(new FontAwesomeModel() { Name = "Pinterest", Code = "\uf0d2", Code_XML = "&#xf0d2" });
            r.Add(new FontAwesomeModel() { Name = "PinterestP", Code = "\uf231", Code_XML = "&#xf231" });
            r.Add(new FontAwesomeModel() { Name = "PinterestSquare", Code = "\uf0d3", Code_XML = "&#xf0d3" });
            r.Add(new FontAwesomeModel() { Name = "PlaceOfWorship", Code = "\uf67f", Code_XML = "&#xf67f" });
            r.Add(new FontAwesomeModel() { Name = "Plane", Code = "\uf072", Code_XML = "&#xf072" });
            r.Add(new FontAwesomeModel() { Name = "PlaneAlt", Code = "\uf3de", Code_XML = "&#xf3de" });
            r.Add(new FontAwesomeModel() { Name = "PlaneArrival", Code = "\uf5af", Code_XML = "&#xf5af" });
            r.Add(new FontAwesomeModel() { Name = "PlaneDeparture", Code = "\uf5b0", Code_XML = "&#xf5b0" });
            r.Add(new FontAwesomeModel() { Name = "Play", Code = "\uf04b", Code_XML = "&#xf04b" });
            r.Add(new FontAwesomeModel() { Name = "PlayCircle", Code = "\uf144", Code_XML = "&#xf144" });
            r.Add(new FontAwesomeModel() { Name = "Playstation", Code = "\uf3df", Code_XML = "&#xf3df" });
            r.Add(new FontAwesomeModel() { Name = "Plug", Code = "\uf1e6", Code_XML = "&#xf1e6" });
            r.Add(new FontAwesomeModel() { Name = "Plus", Code = "\uf067", Code_XML = "&#xf067" });
            r.Add(new FontAwesomeModel() { Name = "PlusCircle", Code = "\uf055", Code_XML = "&#xf055" });
            r.Add(new FontAwesomeModel() { Name = "PlusHexagon", Code = "\uf300", Code_XML = "&#xf300" });
            r.Add(new FontAwesomeModel() { Name = "PlusOctagon", Code = "\uf301", Code_XML = "&#xf301" });
            r.Add(new FontAwesomeModel() { Name = "PlusSquare", Code = "\uf0fe", Code_XML = "&#xf0fe" });
            r.Add(new FontAwesomeModel() { Name = "Podcast", Code = "\uf2ce", Code_XML = "&#xf2ce" });
            r.Add(new FontAwesomeModel() { Name = "Podium", Code = "\uf680", Code_XML = "&#xf680" });
            r.Add(new FontAwesomeModel() { Name = "PodiumStar", Code = "\uf758", Code_XML = "&#xf758" });
            r.Add(new FontAwesomeModel() { Name = "Poll", Code = "\uf681", Code_XML = "&#xf681" });
            r.Add(new FontAwesomeModel() { Name = "PollH", Code = "\uf682", Code_XML = "&#xf682" });
            r.Add(new FontAwesomeModel() { Name = "PollPeople", Code = "\uf759", Code_XML = "&#xf759" });
            r.Add(new FontAwesomeModel() { Name = "Poo", Code = "\uf2fe", Code_XML = "&#xf2fe" });
            r.Add(new FontAwesomeModel() { Name = "PooStorm", Code = "\uf75a", Code_XML = "&#xf75a" });
            r.Add(new FontAwesomeModel() { Name = "Poop", Code = "\uf619", Code_XML = "&#xf619" });
            r.Add(new FontAwesomeModel() { Name = "Portrait", Code = "\uf3e0", Code_XML = "&#xf3e0" });
            r.Add(new FontAwesomeModel() { Name = "PoundSign", Code = "\uf154", Code_XML = "&#xf154" });
            r.Add(new FontAwesomeModel() { Name = "PowerOff", Code = "\uf011", Code_XML = "&#xf011" });
            r.Add(new FontAwesomeModel() { Name = "Pray", Code = "\uf683", Code_XML = "&#xf683" });
            r.Add(new FontAwesomeModel() { Name = "PrayingHands", Code = "\uf684", Code_XML = "&#xf684" });
            r.Add(new FontAwesomeModel() { Name = "Prescription", Code = "\uf5b1", Code_XML = "&#xf5b1" });
            r.Add(new FontAwesomeModel() { Name = "PrescriptionBottle", Code = "\uf485", Code_XML = "&#xf485" });
            r.Add(new FontAwesomeModel() { Name = "PrescriptionBottleAlt", Code = "\uf486", Code_XML = "&#xf486" });
            r.Add(new FontAwesomeModel() { Name = "Presentation", Code = "\uf685", Code_XML = "&#xf685" });
            r.Add(new FontAwesomeModel() { Name = "Print", Code = "\uf02f", Code_XML = "&#xf02f" });
            r.Add(new FontAwesomeModel() { Name = "PrintSlash", Code = "\uf686", Code_XML = "&#xf686" });
            r.Add(new FontAwesomeModel() { Name = "Procedures", Code = "\uf487", Code_XML = "&#xf487" });
            r.Add(new FontAwesomeModel() { Name = "ProductHunt", Code = "\uf288", Code_XML = "&#xf288" });
            r.Add(new FontAwesomeModel() { Name = "ProjectDiagram", Code = "\uf542", Code_XML = "&#xf542" });
            r.Add(new FontAwesomeModel() { Name = "Pumpkin", Code = "\uf707", Code_XML = "&#xf707" });
            r.Add(new FontAwesomeModel() { Name = "Pushed", Code = "\uf3e1", Code_XML = "&#xf3e1" });
            r.Add(new FontAwesomeModel() { Name = "PuzzlePiece", Code = "\uf12e", Code_XML = "&#xf12e" });
            r.Add(new FontAwesomeModel() { Name = "Python", Code = "\uf3e2", Code_XML = "&#xf3e2" });
            r.Add(new FontAwesomeModel() { Name = "Qq", Code = "\uf1d6", Code_XML = "&#xf1d6" });
            r.Add(new FontAwesomeModel() { Name = "Qrcode", Code = "\uf029", Code_XML = "&#xf029" });
            r.Add(new FontAwesomeModel() { Name = "Question", Code = "\uf128", Code_XML = "&#xf128" });
            r.Add(new FontAwesomeModel() { Name = "QuestionCircle", Code = "\uf059", Code_XML = "&#xf059" });
            r.Add(new FontAwesomeModel() { Name = "QuestionSquare", Code = "\uf2fd", Code_XML = "&#xf2fd" });
            r.Add(new FontAwesomeModel() { Name = "Quidditch", Code = "\uf458", Code_XML = "&#xf458" });
            r.Add(new FontAwesomeModel() { Name = "Quinscape", Code = "\uf459", Code_XML = "&#xf459" });
            r.Add(new FontAwesomeModel() { Name = "Quora", Code = "\uf2c4", Code_XML = "&#xf2c4" });
            r.Add(new FontAwesomeModel() { Name = "QuoteLeft", Code = "\uf10d", Code_XML = "&#xf10d" });
            r.Add(new FontAwesomeModel() { Name = "QuoteRight", Code = "\uf10e", Code_XML = "&#xf10e" });
            r.Add(new FontAwesomeModel() { Name = "Quran", Code = "\uf687", Code_XML = "&#xf687" });
            r.Add(new FontAwesomeModel() { Name = "RProject", Code = "\uf4f7", Code_XML = "&#xf4f7" });
            r.Add(new FontAwesomeModel() { Name = "Rabbit", Code = "\uf708", Code_XML = "&#xf708" });
            r.Add(new FontAwesomeModel() { Name = "RabbitFast", Code = "\uf709", Code_XML = "&#xf709" });
            r.Add(new FontAwesomeModel() { Name = "Racquet", Code = "\uf45a", Code_XML = "&#xf45a" });
            r.Add(new FontAwesomeModel() { Name = "Rainbow", Code = "\uf75b", Code_XML = "&#xf75b" });
            r.Add(new FontAwesomeModel() { Name = "Raindrops", Code = "\uf75c", Code_XML = "&#xf75c" });
            r.Add(new FontAwesomeModel() { Name = "Ram", Code = "\uf70a", Code_XML = "&#xf70a" });
            r.Add(new FontAwesomeModel() { Name = "RampLoading", Code = "\uf4d4", Code_XML = "&#xf4d4" });
            r.Add(new FontAwesomeModel() { Name = "Random", Code = "\uf074", Code_XML = "&#xf074" });
            r.Add(new FontAwesomeModel() { Name = "Ravelry", Code = "\uf2d9", Code_XML = "&#xf2d9" });
            r.Add(new FontAwesomeModel() { Name = "React", Code = "\uf41b", Code_XML = "&#xf41b" });
            r.Add(new FontAwesomeModel() { Name = "Reacteurope", Code = "\uf75d", Code_XML = "&#xf75d" });
            r.Add(new FontAwesomeModel() { Name = "Readme", Code = "\uf4d5", Code_XML = "&#xf4d5" });
            r.Add(new FontAwesomeModel() { Name = "Rebel", Code = "\uf1d0", Code_XML = "&#xf1d0" });
            r.Add(new FontAwesomeModel() { Name = "Receipt", Code = "\uf543", Code_XML = "&#xf543" });
            r.Add(new FontAwesomeModel() { Name = "RectangleLandscape", Code = "\uf2fa", Code_XML = "&#xf2fa" });
            r.Add(new FontAwesomeModel() { Name = "RectanglePortrait", Code = "\uf2fb", Code_XML = "&#xf2fb" });
            r.Add(new FontAwesomeModel() { Name = "RectangleWide", Code = "\uf2fc", Code_XML = "&#xf2fc" });
            r.Add(new FontAwesomeModel() { Name = "Recycle", Code = "\uf1b8", Code_XML = "&#xf1b8" });
            r.Add(new FontAwesomeModel() { Name = "RedRiver", Code = "\uf3e3", Code_XML = "&#xf3e3" });
            r.Add(new FontAwesomeModel() { Name = "Reddit", Code = "\uf1a1", Code_XML = "&#xf1a1" });
            r.Add(new FontAwesomeModel() { Name = "RedditAlien", Code = "\uf281", Code_XML = "&#xf281" });
            r.Add(new FontAwesomeModel() { Name = "RedditSquare", Code = "\uf1a2", Code_XML = "&#xf1a2" });
            r.Add(new FontAwesomeModel() { Name = "Redo", Code = "\uf01e", Code_XML = "&#xf01e" });
            r.Add(new FontAwesomeModel() { Name = "RedoAlt", Code = "\uf2f9", Code_XML = "&#xf2f9" });
            r.Add(new FontAwesomeModel() { Name = "Registered", Code = "\uf25d", Code_XML = "&#xf25d" });
            r.Add(new FontAwesomeModel() { Name = "Renren", Code = "\uf18b", Code_XML = "&#xf18b" });
            r.Add(new FontAwesomeModel() { Name = "Repeat", Code = "\uf363", Code_XML = "&#xf363" });
            r.Add(new FontAwesomeModel() { Name = "Repeat1", Code = "\uf365", Code_XML = "&#xf365" });
            r.Add(new FontAwesomeModel() { Name = "Repeat1Alt", Code = "\uf366", Code_XML = "&#xf366" });
            r.Add(new FontAwesomeModel() { Name = "RepeatAlt", Code = "\uf364", Code_XML = "&#xf364" });
            r.Add(new FontAwesomeModel() { Name = "Reply", Code = "\uf3e5", Code_XML = "&#xf3e5" });
            r.Add(new FontAwesomeModel() { Name = "ReplyAll", Code = "\uf122", Code_XML = "&#xf122" });
            r.Add(new FontAwesomeModel() { Name = "Replyd", Code = "\uf3e6", Code_XML = "&#xf3e6" });
            r.Add(new FontAwesomeModel() { Name = "Republican", Code = "\uf75e", Code_XML = "&#xf75e" });
            r.Add(new FontAwesomeModel() { Name = "Researchgate", Code = "\uf4f8", Code_XML = "&#xf4f8" });
            r.Add(new FontAwesomeModel() { Name = "Resolving", Code = "\uf3e7", Code_XML = "&#xf3e7" });
            r.Add(new FontAwesomeModel() { Name = "Retweet", Code = "\uf079", Code_XML = "&#xf079" });
            r.Add(new FontAwesomeModel() { Name = "RetweetAlt", Code = "\uf361", Code_XML = "&#xf361" });
            r.Add(new FontAwesomeModel() { Name = "Rev", Code = "\uf5b2", Code_XML = "&#xf5b2" });
            r.Add(new FontAwesomeModel() { Name = "Ribbon", Code = "\uf4d6", Code_XML = "&#xf4d6" });
            r.Add(new FontAwesomeModel() { Name = "Ring", Code = "\uf70b", Code_XML = "&#xf70b" });
            r.Add(new FontAwesomeModel() { Name = "Road", Code = "\uf018", Code_XML = "&#xf018" });
            r.Add(new FontAwesomeModel() { Name = "Robot", Code = "\uf544", Code_XML = "&#xf544" });
            r.Add(new FontAwesomeModel() { Name = "Rocket", Code = "\uf135", Code_XML = "&#xf135" });
            r.Add(new FontAwesomeModel() { Name = "Rocketchat", Code = "\uf3e8", Code_XML = "&#xf3e8" });
            r.Add(new FontAwesomeModel() { Name = "Rockrms", Code = "\uf3e9", Code_XML = "&#xf3e9" });
            r.Add(new FontAwesomeModel() { Name = "Route", Code = "\uf4d7", Code_XML = "&#xf4d7" });
            r.Add(new FontAwesomeModel() { Name = "RouteHighway", Code = "\uf61a", Code_XML = "&#xf61a" });
            r.Add(new FontAwesomeModel() { Name = "RouteInterstate", Code = "\uf61b", Code_XML = "&#xf61b" });
            r.Add(new FontAwesomeModel() { Name = "Rss", Code = "\uf09e", Code_XML = "&#xf09e" });
            r.Add(new FontAwesomeModel() { Name = "RssSquare", Code = "\uf143", Code_XML = "&#xf143" });
            r.Add(new FontAwesomeModel() { Name = "RubleSign", Code = "\uf158", Code_XML = "&#xf158" });
            r.Add(new FontAwesomeModel() { Name = "Ruler", Code = "\uf545", Code_XML = "&#xf545" });
            r.Add(new FontAwesomeModel() { Name = "RulerCombined", Code = "\uf546", Code_XML = "&#xf546" });
            r.Add(new FontAwesomeModel() { Name = "RulerHorizontal", Code = "\uf547", Code_XML = "&#xf547" });
            r.Add(new FontAwesomeModel() { Name = "RulerTriangle", Code = "\uf61c", Code_XML = "&#xf61c" });
            r.Add(new FontAwesomeModel() { Name = "RulerVertical", Code = "\uf548", Code_XML = "&#xf548" });
            r.Add(new FontAwesomeModel() { Name = "Running", Code = "\uf70c", Code_XML = "&#xf70c" });
            r.Add(new FontAwesomeModel() { Name = "RupeeSign", Code = "\uf156", Code_XML = "&#xf156" });
            r.Add(new FontAwesomeModel() { Name = "SadCry", Code = "\uf5b3", Code_XML = "&#xf5b3" });
            r.Add(new FontAwesomeModel() { Name = "SadTear", Code = "\uf5b4", Code_XML = "&#xf5b4" });
            r.Add(new FontAwesomeModel() { Name = "Safari", Code = "\uf267", Code_XML = "&#xf267" });
            r.Add(new FontAwesomeModel() { Name = "Sass", Code = "\uf41e", Code_XML = "&#xf41e" });
            r.Add(new FontAwesomeModel() { Name = "Save", Code = "\uf0c7", Code_XML = "&#xf0c7" });
            r.Add(new FontAwesomeModel() { Name = "Scalpel", Code = "\uf61d", Code_XML = "&#xf61d" });
            r.Add(new FontAwesomeModel() { Name = "ScalpelPath", Code = "\uf61e", Code_XML = "&#xf61e" });
            r.Add(new FontAwesomeModel() { Name = "Scanner", Code = "\uf488", Code_XML = "&#xf488" });
            r.Add(new FontAwesomeModel() { Name = "ScannerKeyboard", Code = "\uf489", Code_XML = "&#xf489" });
            r.Add(new FontAwesomeModel() { Name = "ScannerTouchscreen", Code = "\uf48a", Code_XML = "&#xf48a" });
            r.Add(new FontAwesomeModel() { Name = "Scarecrow", Code = "\uf70d", Code_XML = "&#xf70d" });
            r.Add(new FontAwesomeModel() { Name = "Schlix", Code = "\uf3ea", Code_XML = "&#xf3ea" });
            r.Add(new FontAwesomeModel() { Name = "School", Code = "\uf549", Code_XML = "&#xf549" });
            r.Add(new FontAwesomeModel() { Name = "Screwdriver", Code = "\uf54a", Code_XML = "&#xf54a" });
            r.Add(new FontAwesomeModel() { Name = "Scribd", Code = "\uf28a", Code_XML = "&#xf28a" });
            r.Add(new FontAwesomeModel() { Name = "Scroll", Code = "\uf70e", Code_XML = "&#xf70e" });
            r.Add(new FontAwesomeModel() { Name = "ScrollOld", Code = "\uf70f", Code_XML = "&#xf70f" });
            r.Add(new FontAwesomeModel() { Name = "Scrubber", Code = "\uf2f8", Code_XML = "&#xf2f8" });
            r.Add(new FontAwesomeModel() { Name = "Scythe", Code = "\uf710", Code_XML = "&#xf710" });
            r.Add(new FontAwesomeModel() { Name = "Search", Code = "\uf002", Code_XML = "&#xf002" });
            r.Add(new FontAwesomeModel() { Name = "SearchDollar", Code = "\uf688", Code_XML = "&#xf688" });
            r.Add(new FontAwesomeModel() { Name = "SearchLocation", Code = "\uf689", Code_XML = "&#xf689" });
            r.Add(new FontAwesomeModel() { Name = "SearchMinus", Code = "\uf010", Code_XML = "&#xf010" });
            r.Add(new FontAwesomeModel() { Name = "SearchPlus", Code = "\uf00e", Code_XML = "&#xf00e" });
            r.Add(new FontAwesomeModel() { Name = "Searchengin", Code = "\uf3eb", Code_XML = "&#xf3eb" });
            r.Add(new FontAwesomeModel() { Name = "Seedling", Code = "\uf4d8", Code_XML = "&#xf4d8" });
            r.Add(new FontAwesomeModel() { Name = "Sellcast", Code = "\uf2da", Code_XML = "&#xf2da" });
            r.Add(new FontAwesomeModel() { Name = "Sellsy", Code = "\uf213", Code_XML = "&#xf213" });
            r.Add(new FontAwesomeModel() { Name = "Server", Code = "\uf233", Code_XML = "&#xf233" });
            r.Add(new FontAwesomeModel() { Name = "Servicestack", Code = "\uf3ec", Code_XML = "&#xf3ec" });
            r.Add(new FontAwesomeModel() { Name = "Shapes", Code = "\uf61f", Code_XML = "&#xf61f" });
            r.Add(new FontAwesomeModel() { Name = "Share", Code = "\uf064", Code_XML = "&#xf064" });
            r.Add(new FontAwesomeModel() { Name = "ShareAll", Code = "\uf367", Code_XML = "&#xf367" });
            r.Add(new FontAwesomeModel() { Name = "ShareAlt", Code = "\uf1e0", Code_XML = "&#xf1e0" });
            r.Add(new FontAwesomeModel() { Name = "ShareAltSquare", Code = "\uf1e1", Code_XML = "&#xf1e1" });
            r.Add(new FontAwesomeModel() { Name = "ShareSquare", Code = "\uf14d", Code_XML = "&#xf14d" });
            r.Add(new FontAwesomeModel() { Name = "Sheep", Code = "\uf711", Code_XML = "&#xf711" });
            r.Add(new FontAwesomeModel() { Name = "ShekelSign", Code = "\uf20b", Code_XML = "&#xf20b" });
            r.Add(new FontAwesomeModel() { Name = "Shield", Code = "\uf132", Code_XML = "&#xf132" });
            r.Add(new FontAwesomeModel() { Name = "ShieldAlt", Code = "\uf3ed", Code_XML = "&#xf3ed" });
            r.Add(new FontAwesomeModel() { Name = "ShieldCheck", Code = "\uf2f7", Code_XML = "&#xf2f7" });
            r.Add(new FontAwesomeModel() { Name = "ShieldCross", Code = "\uf712", Code_XML = "&#xf712" });
            r.Add(new FontAwesomeModel() { Name = "Ship", Code = "\uf21a", Code_XML = "&#xf21a" });
            r.Add(new FontAwesomeModel() { Name = "ShippingFast", Code = "\uf48b", Code_XML = "&#xf48b" });
            r.Add(new FontAwesomeModel() { Name = "ShippingTimed", Code = "\uf48c", Code_XML = "&#xf48c" });
            r.Add(new FontAwesomeModel() { Name = "Shirtsinbulk", Code = "\uf214", Code_XML = "&#xf214" });
            r.Add(new FontAwesomeModel() { Name = "ShoePrints", Code = "\uf54b", Code_XML = "&#xf54b" });
            r.Add(new FontAwesomeModel() { Name = "ShoppingBag", Code = "\uf290", Code_XML = "&#xf290" });
            r.Add(new FontAwesomeModel() { Name = "ShoppingBasket", Code = "\uf291", Code_XML = "&#xf291" });
            r.Add(new FontAwesomeModel() { Name = "ShoppingCart", Code = "\uf07a", Code_XML = "&#xf07a" });
            r.Add(new FontAwesomeModel() { Name = "Shopware", Code = "\uf5b5", Code_XML = "&#xf5b5" });
            r.Add(new FontAwesomeModel() { Name = "Shovel", Code = "\uf713", Code_XML = "&#xf713" });
            r.Add(new FontAwesomeModel() { Name = "Shower", Code = "\uf2cc", Code_XML = "&#xf2cc" });
            r.Add(new FontAwesomeModel() { Name = "Shredder", Code = "\uf68a", Code_XML = "&#xf68a" });
            r.Add(new FontAwesomeModel() { Name = "ShuttleVan", Code = "\uf5b6", Code_XML = "&#xf5b6" });
            r.Add(new FontAwesomeModel() { Name = "Shuttlecock", Code = "\uf45b", Code_XML = "&#xf45b" });
            r.Add(new FontAwesomeModel() { Name = "Sigma", Code = "\uf68b", Code_XML = "&#xf68b" });
            r.Add(new FontAwesomeModel() { Name = "Sign", Code = "\uf4d9", Code_XML = "&#xf4d9" });
            r.Add(new FontAwesomeModel() { Name = "SignIn", Code = "\uf090", Code_XML = "&#xf090" });
            r.Add(new FontAwesomeModel() { Name = "SignInAlt", Code = "\uf2f6", Code_XML = "&#xf2f6" });
            r.Add(new FontAwesomeModel() { Name = "SignLanguage", Code = "\uf2a7", Code_XML = "&#xf2a7" });
            r.Add(new FontAwesomeModel() { Name = "SignOut", Code = "\uf08b", Code_XML = "&#xf08b" });
            r.Add(new FontAwesomeModel() { Name = "SignOutAlt", Code = "\uf2f5", Code_XML = "&#xf2f5" });
            r.Add(new FontAwesomeModel() { Name = "Signal", Code = "\uf012", Code_XML = "&#xf012" });
            r.Add(new FontAwesomeModel() { Name = "Signal1", Code = "\uf68c", Code_XML = "&#xf68c" });
            r.Add(new FontAwesomeModel() { Name = "Signal2", Code = "\uf68d", Code_XML = "&#xf68d" });
            r.Add(new FontAwesomeModel() { Name = "Signal3", Code = "\uf68e", Code_XML = "&#xf68e" });
            r.Add(new FontAwesomeModel() { Name = "Signal4", Code = "\uf68f", Code_XML = "&#xf68f" });
            r.Add(new FontAwesomeModel() { Name = "SignalAlt", Code = "\uf690", Code_XML = "&#xf690" });
            r.Add(new FontAwesomeModel() { Name = "SignalAlt1", Code = "\uf691", Code_XML = "&#xf691" });
            r.Add(new FontAwesomeModel() { Name = "SignalAlt2", Code = "\uf692", Code_XML = "&#xf692" });
            r.Add(new FontAwesomeModel() { Name = "SignalAlt3", Code = "\uf693", Code_XML = "&#xf693" });
            r.Add(new FontAwesomeModel() { Name = "SignalAltSlash", Code = "\uf694", Code_XML = "&#xf694" });
            r.Add(new FontAwesomeModel() { Name = "SignalSlash", Code = "\uf695", Code_XML = "&#xf695" });
            r.Add(new FontAwesomeModel() { Name = "Signature", Code = "\uf5b7", Code_XML = "&#xf5b7" });
            r.Add(new FontAwesomeModel() { Name = "Simplybuilt", Code = "\uf215", Code_XML = "&#xf215" });
            r.Add(new FontAwesomeModel() { Name = "Sistrix", Code = "\uf3ee", Code_XML = "&#xf3ee" });
            r.Add(new FontAwesomeModel() { Name = "Sitemap", Code = "\uf0e8", Code_XML = "&#xf0e8" });
            r.Add(new FontAwesomeModel() { Name = "Sith", Code = "\uf512", Code_XML = "&#xf512" });
            r.Add(new FontAwesomeModel() { Name = "Skeleton", Code = "\uf620", Code_XML = "&#xf620" });
            r.Add(new FontAwesomeModel() { Name = "Skull", Code = "\uf54c", Code_XML = "&#xf54c" });
            r.Add(new FontAwesomeModel() { Name = "SkullCrossbones", Code = "\uf714", Code_XML = "&#xf714" });
            r.Add(new FontAwesomeModel() { Name = "Skyatlas", Code = "\uf216", Code_XML = "&#xf216" });
            r.Add(new FontAwesomeModel() { Name = "Skype", Code = "\uf17e", Code_XML = "&#xf17e" });
            r.Add(new FontAwesomeModel() { Name = "Slack", Code = "\uf198", Code_XML = "&#xf198" });
            r.Add(new FontAwesomeModel() { Name = "SlackHash", Code = "\uf3ef", Code_XML = "&#xf3ef" });
            r.Add(new FontAwesomeModel() { Name = "Slash", Code = "\uf715", Code_XML = "&#xf715" });
            r.Add(new FontAwesomeModel() { Name = "SlidersH", Code = "\uf1de", Code_XML = "&#xf1de" });
            r.Add(new FontAwesomeModel() { Name = "SlidersHSquare", Code = "\uf3f0", Code_XML = "&#xf3f0" });
            r.Add(new FontAwesomeModel() { Name = "SlidersV", Code = "\uf3f1", Code_XML = "&#xf3f1" });
            r.Add(new FontAwesomeModel() { Name = "SlidersVSquare", Code = "\uf3f2", Code_XML = "&#xf3f2" });
            r.Add(new FontAwesomeModel() { Name = "Slideshare", Code = "\uf1e7", Code_XML = "&#xf1e7" });
            r.Add(new FontAwesomeModel() { Name = "Smile", Code = "\uf118", Code_XML = "&#xf118" });
            r.Add(new FontAwesomeModel() { Name = "SmileBeam", Code = "\uf5b8", Code_XML = "&#xf5b8" });
            r.Add(new FontAwesomeModel() { Name = "SmilePlus", Code = "\uf5b9", Code_XML = "&#xf5b9" });
            r.Add(new FontAwesomeModel() { Name = "SmileWink", Code = "\uf4da", Code_XML = "&#xf4da" });
            r.Add(new FontAwesomeModel() { Name = "Smog", Code = "\uf75f", Code_XML = "&#xf75f" });
            r.Add(new FontAwesomeModel() { Name = "Smoke", Code = "\uf760", Code_XML = "&#xf760" });
            r.Add(new FontAwesomeModel() { Name = "Smoking", Code = "\uf48d", Code_XML = "&#xf48d" });
            r.Add(new FontAwesomeModel() { Name = "SmokingBan", Code = "\uf54d", Code_XML = "&#xf54d" });
            r.Add(new FontAwesomeModel() { Name = "Snake", Code = "\uf716", Code_XML = "&#xf716" });
            r.Add(new FontAwesomeModel() { Name = "Snapchat", Code = "\uf2ab", Code_XML = "&#xf2ab" });
            r.Add(new FontAwesomeModel() { Name = "SnapchatGhost", Code = "\uf2ac", Code_XML = "&#xf2ac" });
            r.Add(new FontAwesomeModel() { Name = "SnapchatSquare", Code = "\uf2ad", Code_XML = "&#xf2ad" });
            r.Add(new FontAwesomeModel() { Name = "SnowBlowing", Code = "\uf761", Code_XML = "&#xf761" });
            r.Add(new FontAwesomeModel() { Name = "Snowflake", Code = "\uf2dc", Code_XML = "&#xf2dc" });
            r.Add(new FontAwesomeModel() { Name = "Socks", Code = "\uf696", Code_XML = "&#xf696" });
            r.Add(new FontAwesomeModel() { Name = "SolarPanel", Code = "\uf5ba", Code_XML = "&#xf5ba" });
            r.Add(new FontAwesomeModel() { Name = "Sort", Code = "\uf0dc", Code_XML = "&#xf0dc" });
            r.Add(new FontAwesomeModel() { Name = "SortAlphaDown", Code = "\uf15d", Code_XML = "&#xf15d" });
            r.Add(new FontAwesomeModel() { Name = "SortAlphaUp", Code = "\uf15e", Code_XML = "&#xf15e" });
            r.Add(new FontAwesomeModel() { Name = "SortAmountDown", Code = "\uf160", Code_XML = "&#xf160" });
            r.Add(new FontAwesomeModel() { Name = "SortAmountUp", Code = "\uf161", Code_XML = "&#xf161" });
            r.Add(new FontAwesomeModel() { Name = "SortDown", Code = "\uf0dd", Code_XML = "&#xf0dd" });
            r.Add(new FontAwesomeModel() { Name = "SortNumericDown", Code = "\uf162", Code_XML = "&#xf162" });
            r.Add(new FontAwesomeModel() { Name = "SortNumericUp", Code = "\uf163", Code_XML = "&#xf163" });
            r.Add(new FontAwesomeModel() { Name = "SortUp", Code = "\uf0de", Code_XML = "&#xf0de" });
            r.Add(new FontAwesomeModel() { Name = "Soundcloud", Code = "\uf1be", Code_XML = "&#xf1be" });
            r.Add(new FontAwesomeModel() { Name = "Spa", Code = "\uf5bb", Code_XML = "&#xf5bb" });
            r.Add(new FontAwesomeModel() { Name = "SpaceShuttle", Code = "\uf197", Code_XML = "&#xf197" });
            r.Add(new FontAwesomeModel() { Name = "Spade", Code = "\uf2f4", Code_XML = "&#xf2f4" });
            r.Add(new FontAwesomeModel() { Name = "Speakap", Code = "\uf3f3", Code_XML = "&#xf3f3" });
            r.Add(new FontAwesomeModel() { Name = "Spider", Code = "\uf717", Code_XML = "&#xf717" });
            r.Add(new FontAwesomeModel() { Name = "SpiderBlackWidow", Code = "\uf718", Code_XML = "&#xf718" });
            r.Add(new FontAwesomeModel() { Name = "SpiderWeb", Code = "\uf719", Code_XML = "&#xf719" });
            r.Add(new FontAwesomeModel() { Name = "Spinner", Code = "\uf110", Code_XML = "&#xf110" });
            r.Add(new FontAwesomeModel() { Name = "SpinnerThird", Code = "\uf3f4", Code_XML = "&#xf3f4" });
            r.Add(new FontAwesomeModel() { Name = "Splotch", Code = "\uf5bc", Code_XML = "&#xf5bc" });
            r.Add(new FontAwesomeModel() { Name = "Spotify", Code = "\uf1bc", Code_XML = "&#xf1bc" });
            r.Add(new FontAwesomeModel() { Name = "SprayCan", Code = "\uf5bd", Code_XML = "&#xf5bd" });
            r.Add(new FontAwesomeModel() { Name = "Square", Code = "\uf0c8", Code_XML = "&#xf0c8" });
            r.Add(new FontAwesomeModel() { Name = "SquareFull", Code = "\uf45c", Code_XML = "&#xf45c" });
            r.Add(new FontAwesomeModel() { Name = "SquareRoot", Code = "\uf697", Code_XML = "&#xf697" });
            r.Add(new FontAwesomeModel() { Name = "SquareRootAlt", Code = "\uf698", Code_XML = "&#xf698" });
            r.Add(new FontAwesomeModel() { Name = "Squarespace", Code = "\uf5be", Code_XML = "&#xf5be" });
            r.Add(new FontAwesomeModel() { Name = "Squirrel", Code = "\uf71a", Code_XML = "&#xf71a" });
            r.Add(new FontAwesomeModel() { Name = "StackExchange", Code = "\uf18d", Code_XML = "&#xf18d" });
            r.Add(new FontAwesomeModel() { Name = "StackOverflow", Code = "\uf16c", Code_XML = "&#xf16c" });
            r.Add(new FontAwesomeModel() { Name = "Staff", Code = "\uf71b", Code_XML = "&#xf71b" });
            r.Add(new FontAwesomeModel() { Name = "Stamp", Code = "\uf5bf", Code_XML = "&#xf5bf" });
            r.Add(new FontAwesomeModel() { Name = "Star", Code = "\uf005", Code_XML = "&#xf005" });
            r.Add(new FontAwesomeModel() { Name = "StarAndCrescent", Code = "\uf699", Code_XML = "&#xf699" });
            r.Add(new FontAwesomeModel() { Name = "StarExclamation", Code = "\uf2f3", Code_XML = "&#xf2f3" });
            r.Add(new FontAwesomeModel() { Name = "StarHalf", Code = "\uf089", Code_XML = "&#xf089" });
            r.Add(new FontAwesomeModel() { Name = "StarHalfAlt", Code = "\uf5c0", Code_XML = "&#xf5c0" });
            r.Add(new FontAwesomeModel() { Name = "StarOfDavid", Code = "\uf69a", Code_XML = "&#xf69a" });
            r.Add(new FontAwesomeModel() { Name = "StarOfLife", Code = "\uf621", Code_XML = "&#xf621" });
            r.Add(new FontAwesomeModel() { Name = "Stars", Code = "\uf762", Code_XML = "&#xf762" });
            r.Add(new FontAwesomeModel() { Name = "Staylinked", Code = "\uf3f5", Code_XML = "&#xf3f5" });
            r.Add(new FontAwesomeModel() { Name = "Steam", Code = "\uf1b6", Code_XML = "&#xf1b6" });
            r.Add(new FontAwesomeModel() { Name = "SteamSquare", Code = "\uf1b7", Code_XML = "&#xf1b7" });
            r.Add(new FontAwesomeModel() { Name = "SteamSymbol", Code = "\uf3f6", Code_XML = "&#xf3f6" });
            r.Add(new FontAwesomeModel() { Name = "SteeringWheel", Code = "\uf622", Code_XML = "&#xf622" });
            r.Add(new FontAwesomeModel() { Name = "StepBackward", Code = "\uf048", Code_XML = "&#xf048" });
            r.Add(new FontAwesomeModel() { Name = "StepForward", Code = "\uf051", Code_XML = "&#xf051" });
            r.Add(new FontAwesomeModel() { Name = "Stethoscope", Code = "\uf0f1", Code_XML = "&#xf0f1" });
            r.Add(new FontAwesomeModel() { Name = "StickerMule", Code = "\uf3f7", Code_XML = "&#xf3f7" });
            r.Add(new FontAwesomeModel() { Name = "StickyNote", Code = "\uf249", Code_XML = "&#xf249" });
            r.Add(new FontAwesomeModel() { Name = "Stomach", Code = "\uf623", Code_XML = "&#xf623" });
            r.Add(new FontAwesomeModel() { Name = "Stop", Code = "\uf04d", Code_XML = "&#xf04d" });
            r.Add(new FontAwesomeModel() { Name = "StopCircle", Code = "\uf28d", Code_XML = "&#xf28d" });
            r.Add(new FontAwesomeModel() { Name = "Stopwatch", Code = "\uf2f2", Code_XML = "&#xf2f2" });
            r.Add(new FontAwesomeModel() { Name = "Store", Code = "\uf54e", Code_XML = "&#xf54e" });
            r.Add(new FontAwesomeModel() { Name = "StoreAlt", Code = "\uf54f", Code_XML = "&#xf54f" });
            r.Add(new FontAwesomeModel() { Name = "Strava", Code = "\uf428", Code_XML = "&#xf428" });
            r.Add(new FontAwesomeModel() { Name = "Stream", Code = "\uf550", Code_XML = "&#xf550" });
            r.Add(new FontAwesomeModel() { Name = "StreetView", Code = "\uf21d", Code_XML = "&#xf21d" });
            r.Add(new FontAwesomeModel() { Name = "Strikethrough", Code = "\uf0cc", Code_XML = "&#xf0cc" });
            r.Add(new FontAwesomeModel() { Name = "Stripe", Code = "\uf429", Code_XML = "&#xf429" });
            r.Add(new FontAwesomeModel() { Name = "StripeS", Code = "\uf42a", Code_XML = "&#xf42a" });
            r.Add(new FontAwesomeModel() { Name = "Stroopwafel", Code = "\uf551", Code_XML = "&#xf551" });
            r.Add(new FontAwesomeModel() { Name = "Studiovinari", Code = "\uf3f8", Code_XML = "&#xf3f8" });
            r.Add(new FontAwesomeModel() { Name = "Stumbleupon", Code = "\uf1a4", Code_XML = "&#xf1a4" });
            r.Add(new FontAwesomeModel() { Name = "StumbleuponCircle", Code = "\uf1a3", Code_XML = "&#xf1a3" });
            r.Add(new FontAwesomeModel() { Name = "Subscript", Code = "\uf12c", Code_XML = "&#xf12c" });
            r.Add(new FontAwesomeModel() { Name = "Subway", Code = "\uf239", Code_XML = "&#xf239" });
            r.Add(new FontAwesomeModel() { Name = "Suitcase", Code = "\uf0f2", Code_XML = "&#xf0f2" });
            r.Add(new FontAwesomeModel() { Name = "SuitcaseRolling", Code = "\uf5c1", Code_XML = "&#xf5c1" });
            r.Add(new FontAwesomeModel() { Name = "Sun", Code = "\uf185", Code_XML = "&#xf185" });
            r.Add(new FontAwesomeModel() { Name = "SunCloud", Code = "\uf763", Code_XML = "&#xf763" });
            r.Add(new FontAwesomeModel() { Name = "SunDust", Code = "\uf764", Code_XML = "&#xf764" });
            r.Add(new FontAwesomeModel() { Name = "SunHaze", Code = "\uf765", Code_XML = "&#xf765" });
            r.Add(new FontAwesomeModel() { Name = "Sunrise", Code = "\uf766", Code_XML = "&#xf766" });
            r.Add(new FontAwesomeModel() { Name = "Sunset", Code = "\uf767", Code_XML = "&#xf767" });
            r.Add(new FontAwesomeModel() { Name = "Superpowers", Code = "\uf2dd", Code_XML = "&#xf2dd" });
            r.Add(new FontAwesomeModel() { Name = "Superscript", Code = "\uf12b", Code_XML = "&#xf12b" });
            r.Add(new FontAwesomeModel() { Name = "Supple", Code = "\uf3f9", Code_XML = "&#xf3f9" });
            r.Add(new FontAwesomeModel() { Name = "Surprise", Code = "\uf5c2", Code_XML = "&#xf5c2" });
            r.Add(new FontAwesomeModel() { Name = "Swatchbook", Code = "\uf5c3", Code_XML = "&#xf5c3" });
            r.Add(new FontAwesomeModel() { Name = "Swimmer", Code = "\uf5c4", Code_XML = "&#xf5c4" });
            r.Add(new FontAwesomeModel() { Name = "SwimmingPool", Code = "\uf5c5", Code_XML = "&#xf5c5" });
            r.Add(new FontAwesomeModel() { Name = "Sword", Code = "\uf71c", Code_XML = "&#xf71c" });
            r.Add(new FontAwesomeModel() { Name = "Swords", Code = "\uf71d", Code_XML = "&#xf71d" });
            r.Add(new FontAwesomeModel() { Name = "Synagogue", Code = "\uf69b", Code_XML = "&#xf69b" });
            r.Add(new FontAwesomeModel() { Name = "Sync", Code = "\uf021", Code_XML = "&#xf021" });
            r.Add(new FontAwesomeModel() { Name = "SyncAlt", Code = "\uf2f1", Code_XML = "&#xf2f1" });
            r.Add(new FontAwesomeModel() { Name = "Syringe", Code = "\uf48e", Code_XML = "&#xf48e" });
            r.Add(new FontAwesomeModel() { Name = "Table", Code = "\uf0ce", Code_XML = "&#xf0ce" });
            r.Add(new FontAwesomeModel() { Name = "TableTennis", Code = "\uf45d", Code_XML = "&#xf45d" });
            r.Add(new FontAwesomeModel() { Name = "Tablet", Code = "\uf10a", Code_XML = "&#xf10a" });
            r.Add(new FontAwesomeModel() { Name = "TabletAlt", Code = "\uf3fa", Code_XML = "&#xf3fa" });
            r.Add(new FontAwesomeModel() { Name = "TabletAndroid", Code = "\uf3fb", Code_XML = "&#xf3fb" });
            r.Add(new FontAwesomeModel() { Name = "TabletAndroidAlt", Code = "\uf3fc", Code_XML = "&#xf3fc" });
            r.Add(new FontAwesomeModel() { Name = "TabletRugged", Code = "\uf48f", Code_XML = "&#xf48f" });
            r.Add(new FontAwesomeModel() { Name = "Tablets", Code = "\uf490", Code_XML = "&#xf490" });
            r.Add(new FontAwesomeModel() { Name = "Tachometer", Code = "\uf0e4", Code_XML = "&#xf0e4" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAlt", Code = "\uf3fd", Code_XML = "&#xf3fd" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAltAverage", Code = "\uf624", Code_XML = "&#xf624" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAltFast", Code = "\uf625", Code_XML = "&#xf625" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAltFastest", Code = "\uf626", Code_XML = "&#xf626" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAltSlow", Code = "\uf627", Code_XML = "&#xf627" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAltSlowest", Code = "\uf628", Code_XML = "&#xf628" });
            r.Add(new FontAwesomeModel() { Name = "TachometerAverage", Code = "\uf629", Code_XML = "&#xf629" });
            r.Add(new FontAwesomeModel() { Name = "TachometerFast", Code = "\uf62a", Code_XML = "&#xf62a" });
            r.Add(new FontAwesomeModel() { Name = "TachometerFastest", Code = "\uf62b", Code_XML = "&#xf62b" });
            r.Add(new FontAwesomeModel() { Name = "TachometerSlow", Code = "\uf62c", Code_XML = "&#xf62c" });
            r.Add(new FontAwesomeModel() { Name = "TachometerSlowest", Code = "\uf62d", Code_XML = "&#xf62d" });
            r.Add(new FontAwesomeModel() { Name = "Tag", Code = "\uf02b", Code_XML = "&#xf02b" });
            r.Add(new FontAwesomeModel() { Name = "Tags", Code = "\uf02c", Code_XML = "&#xf02c" });
            r.Add(new FontAwesomeModel() { Name = "Tally", Code = "\uf69c", Code_XML = "&#xf69c" });
            r.Add(new FontAwesomeModel() { Name = "Tape", Code = "\uf4db", Code_XML = "&#xf4db" });
            r.Add(new FontAwesomeModel() { Name = "Tasks", Code = "\uf0ae", Code_XML = "&#xf0ae" });
            r.Add(new FontAwesomeModel() { Name = "Taxi", Code = "\uf1ba", Code_XML = "&#xf1ba" });
            r.Add(new FontAwesomeModel() { Name = "Teamspeak", Code = "\uf4f9", Code_XML = "&#xf4f9" });
            r.Add(new FontAwesomeModel() { Name = "Teeth", Code = "\uf62e", Code_XML = "&#xf62e" });
            r.Add(new FontAwesomeModel() { Name = "TeethOpen", Code = "\uf62f", Code_XML = "&#xf62f" });
            r.Add(new FontAwesomeModel() { Name = "Telegram", Code = "\uf2c6", Code_XML = "&#xf2c6" });
            r.Add(new FontAwesomeModel() { Name = "TelegramPlane", Code = "\uf3fe", Code_XML = "&#xf3fe" });
            r.Add(new FontAwesomeModel() { Name = "TemperatureFrigid", Code = "\uf768", Code_XML = "&#xf768" });
            r.Add(new FontAwesomeModel() { Name = "TemperatureHigh", Code = "\uf769", Code_XML = "&#xf769" });
            r.Add(new FontAwesomeModel() { Name = "TemperatureHot", Code = "\uf76a", Code_XML = "&#xf76a" });
            r.Add(new FontAwesomeModel() { Name = "TemperatureLow", Code = "\uf76b", Code_XML = "&#xf76b" });
            r.Add(new FontAwesomeModel() { Name = "TencentWeibo", Code = "\uf1d5", Code_XML = "&#xf1d5" });
            r.Add(new FontAwesomeModel() { Name = "TennisBall", Code = "\uf45e", Code_XML = "&#xf45e" });
            r.Add(new FontAwesomeModel() { Name = "Terminal", Code = "\uf120", Code_XML = "&#xf120" });
            r.Add(new FontAwesomeModel() { Name = "TextHeight", Code = "\uf034", Code_XML = "&#xf034" });
            r.Add(new FontAwesomeModel() { Name = "TextWidth", Code = "\uf035", Code_XML = "&#xf035" });
            r.Add(new FontAwesomeModel() { Name = "Th", Code = "\uf00a", Code_XML = "&#xf00a" });
            r.Add(new FontAwesomeModel() { Name = "ThLarge", Code = "\uf009", Code_XML = "&#xf009" });
            r.Add(new FontAwesomeModel() { Name = "ThList", Code = "\uf00b", Code_XML = "&#xf00b" });
            r.Add(new FontAwesomeModel() { Name = "TheRedYeti", Code = "\uf69d", Code_XML = "&#xf69d" });
            r.Add(new FontAwesomeModel() { Name = "TheaterMasks", Code = "\uf630", Code_XML = "&#xf630" });
            r.Add(new FontAwesomeModel() { Name = "Themeco", Code = "\uf5c6", Code_XML = "&#xf5c6" });
            r.Add(new FontAwesomeModel() { Name = "Themeisle", Code = "\uf2b2", Code_XML = "&#xf2b2" });
            r.Add(new FontAwesomeModel() { Name = "Thermometer", Code = "\uf491", Code_XML = "&#xf491" });
            r.Add(new FontAwesomeModel() { Name = "ThermometerEmpty", Code = "\uf2cb", Code_XML = "&#xf2cb" });
            r.Add(new FontAwesomeModel() { Name = "ThermometerFull", Code = "\uf2c7", Code_XML = "&#xf2c7" });
            r.Add(new FontAwesomeModel() { Name = "ThermometerHalf", Code = "\uf2c9", Code_XML = "&#xf2c9" });
            r.Add(new FontAwesomeModel() { Name = "ThermometerQuarter", Code = "\uf2ca", Code_XML = "&#xf2ca" });
            r.Add(new FontAwesomeModel() { Name = "ThermometerThreeQuarters", Code = "\uf2c8", Code_XML = "&#xf2c8" });
            r.Add(new FontAwesomeModel() { Name = "Theta", Code = "\uf69e", Code_XML = "&#xf69e" });
            r.Add(new FontAwesomeModel() { Name = "ThinkPeaks", Code = "\uf731", Code_XML = "&#xf731" });
            r.Add(new FontAwesomeModel() { Name = "ThumbsDown", Code = "\uf165", Code_XML = "&#xf165" });
            r.Add(new FontAwesomeModel() { Name = "ThumbsUp", Code = "\uf164", Code_XML = "&#xf164" });
            r.Add(new FontAwesomeModel() { Name = "Thumbtack", Code = "\uf08d", Code_XML = "&#xf08d" });
            r.Add(new FontAwesomeModel() { Name = "Thunderstorm", Code = "\uf76c", Code_XML = "&#xf76c" });
            r.Add(new FontAwesomeModel() { Name = "ThunderstormMoon", Code = "\uf76d", Code_XML = "&#xf76d" });
            r.Add(new FontAwesomeModel() { Name = "ThunderstormSun", Code = "\uf76e", Code_XML = "&#xf76e" });
            r.Add(new FontAwesomeModel() { Name = "Ticket", Code = "\uf145", Code_XML = "&#xf145" });
            r.Add(new FontAwesomeModel() { Name = "TicketAlt", Code = "\uf3ff", Code_XML = "&#xf3ff" });
            r.Add(new FontAwesomeModel() { Name = "Tilde", Code = "\uf69f", Code_XML = "&#xf69f" });
            r.Add(new FontAwesomeModel() { Name = "Times", Code = "\uf00d", Code_XML = "&#xf00d" });
            r.Add(new FontAwesomeModel() { Name = "TimesCircle", Code = "\uf057", Code_XML = "&#xf057" });
            r.Add(new FontAwesomeModel() { Name = "TimesHexagon", Code = "\uf2ee", Code_XML = "&#xf2ee" });
            r.Add(new FontAwesomeModel() { Name = "TimesOctagon", Code = "\uf2f0", Code_XML = "&#xf2f0" });
            r.Add(new FontAwesomeModel() { Name = "TimesSquare", Code = "\uf2d3", Code_XML = "&#xf2d3" });
            r.Add(new FontAwesomeModel() { Name = "Tint", Code = "\uf043", Code_XML = "&#xf043" });
            r.Add(new FontAwesomeModel() { Name = "TintSlash", Code = "\uf5c7", Code_XML = "&#xf5c7" });
            r.Add(new FontAwesomeModel() { Name = "Tire", Code = "\uf631", Code_XML = "&#xf631" });
            r.Add(new FontAwesomeModel() { Name = "TireFlat", Code = "\uf632", Code_XML = "&#xf632" });
            r.Add(new FontAwesomeModel() { Name = "TirePressureWarning", Code = "\uf633", Code_XML = "&#xf633" });
            r.Add(new FontAwesomeModel() { Name = "TireRugged", Code = "\uf634", Code_XML = "&#xf634" });
            r.Add(new FontAwesomeModel() { Name = "Tired", Code = "\uf5c8", Code_XML = "&#xf5c8" });
            r.Add(new FontAwesomeModel() { Name = "ToggleOff", Code = "\uf204", Code_XML = "&#xf204" });
            r.Add(new FontAwesomeModel() { Name = "ToggleOn", Code = "\uf205", Code_XML = "&#xf205" });
            r.Add(new FontAwesomeModel() { Name = "ToiletPaper", Code = "\uf71e", Code_XML = "&#xf71e" });
            r.Add(new FontAwesomeModel() { Name = "ToiletPaperAlt", Code = "\uf71f", Code_XML = "&#xf71f" });
            r.Add(new FontAwesomeModel() { Name = "Tombstone", Code = "\uf720", Code_XML = "&#xf720" });
            r.Add(new FontAwesomeModel() { Name = "TombstoneAlt", Code = "\uf721", Code_XML = "&#xf721" });
            r.Add(new FontAwesomeModel() { Name = "Toolbox", Code = "\uf552", Code_XML = "&#xf552" });
            r.Add(new FontAwesomeModel() { Name = "Tooth", Code = "\uf5c9", Code_XML = "&#xf5c9" });
            r.Add(new FontAwesomeModel() { Name = "Toothbrush", Code = "\uf635", Code_XML = "&#xf635" });
            r.Add(new FontAwesomeModel() { Name = "Torah", Code = "\uf6a0", Code_XML = "&#xf6a0" });
            r.Add(new FontAwesomeModel() { Name = "ToriiGate", Code = "\uf6a1", Code_XML = "&#xf6a1" });
            r.Add(new FontAwesomeModel() { Name = "Tornado", Code = "\uf76f", Code_XML = "&#xf76f" });
            r.Add(new FontAwesomeModel() { Name = "Tractor", Code = "\uf722", Code_XML = "&#xf722" });
            r.Add(new FontAwesomeModel() { Name = "TradeFederation", Code = "\uf513", Code_XML = "&#xf513" });
            r.Add(new FontAwesomeModel() { Name = "Trademark", Code = "\uf25c", Code_XML = "&#xf25c" });
            r.Add(new FontAwesomeModel() { Name = "TrafficCone", Code = "\uf636", Code_XML = "&#xf636" });
            r.Add(new FontAwesomeModel() { Name = "TrafficLight", Code = "\uf637", Code_XML = "&#xf637" });
            r.Add(new FontAwesomeModel() { Name = "TrafficLightGo", Code = "\uf638", Code_XML = "&#xf638" });
            r.Add(new FontAwesomeModel() { Name = "TrafficLightSlow", Code = "\uf639", Code_XML = "&#xf639" });
            r.Add(new FontAwesomeModel() { Name = "TrafficLightStop", Code = "\uf63a", Code_XML = "&#xf63a" });
            r.Add(new FontAwesomeModel() { Name = "Train", Code = "\uf238", Code_XML = "&#xf238" });
            r.Add(new FontAwesomeModel() { Name = "Transgender", Code = "\uf224", Code_XML = "&#xf224" });
            r.Add(new FontAwesomeModel() { Name = "TransgenderAlt", Code = "\uf225", Code_XML = "&#xf225" });
            r.Add(new FontAwesomeModel() { Name = "Trash", Code = "\uf1f8", Code_XML = "&#xf1f8" });
            r.Add(new FontAwesomeModel() { Name = "TrashAlt", Code = "\uf2ed", Code_XML = "&#xf2ed" });
            r.Add(new FontAwesomeModel() { Name = "TreasureChest", Code = "\uf723", Code_XML = "&#xf723" });
            r.Add(new FontAwesomeModel() { Name = "Tree", Code = "\uf1bb", Code_XML = "&#xf1bb" });
            r.Add(new FontAwesomeModel() { Name = "TreeAlt", Code = "\uf400", Code_XML = "&#xf400" });
            r.Add(new FontAwesomeModel() { Name = "Trees", Code = "\uf724", Code_XML = "&#xf724" });
            r.Add(new FontAwesomeModel() { Name = "Trello", Code = "\uf181", Code_XML = "&#xf181" });
            r.Add(new FontAwesomeModel() { Name = "Triangle", Code = "\uf2ec", Code_XML = "&#xf2ec" });
            r.Add(new FontAwesomeModel() { Name = "Tripadvisor", Code = "\uf262", Code_XML = "&#xf262" });
            r.Add(new FontAwesomeModel() { Name = "Trophy", Code = "\uf091", Code_XML = "&#xf091" });
            r.Add(new FontAwesomeModel() { Name = "TrophyAlt", Code = "\uf2eb", Code_XML = "&#xf2eb" });
            r.Add(new FontAwesomeModel() { Name = "Truck", Code = "\uf0d1", Code_XML = "&#xf0d1" });
            r.Add(new FontAwesomeModel() { Name = "TruckContainer", Code = "\uf4dc", Code_XML = "&#xf4dc" });
            r.Add(new FontAwesomeModel() { Name = "TruckCouch", Code = "\uf4dd", Code_XML = "&#xf4dd" });
            r.Add(new FontAwesomeModel() { Name = "TruckLoading", Code = "\uf4de", Code_XML = "&#xf4de" });
            r.Add(new FontAwesomeModel() { Name = "TruckMonster", Code = "\uf63b", Code_XML = "&#xf63b" });
            r.Add(new FontAwesomeModel() { Name = "TruckMoving", Code = "\uf4df", Code_XML = "&#xf4df" });
            r.Add(new FontAwesomeModel() { Name = "TruckPickup", Code = "\uf63c", Code_XML = "&#xf63c" });
            r.Add(new FontAwesomeModel() { Name = "TruckRamp", Code = "\uf4e0", Code_XML = "&#xf4e0" });
            r.Add(new FontAwesomeModel() { Name = "Tshirt", Code = "\uf553", Code_XML = "&#xf553" });
            r.Add(new FontAwesomeModel() { Name = "Tty", Code = "\uf1e4", Code_XML = "&#xf1e4" });
            r.Add(new FontAwesomeModel() { Name = "Tumblr", Code = "\uf173", Code_XML = "&#xf173" });
            r.Add(new FontAwesomeModel() { Name = "TumblrSquare", Code = "\uf174", Code_XML = "&#xf174" });
            r.Add(new FontAwesomeModel() { Name = "Turkey", Code = "\uf725", Code_XML = "&#xf725" });
            r.Add(new FontAwesomeModel() { Name = "Turtle", Code = "\uf726", Code_XML = "&#xf726" });
            r.Add(new FontAwesomeModel() { Name = "Tv", Code = "\uf26c", Code_XML = "&#xf26c" });
            r.Add(new FontAwesomeModel() { Name = "TvRetro", Code = "\uf401", Code_XML = "&#xf401" });
            r.Add(new FontAwesomeModel() { Name = "Twitch", Code = "\uf1e8", Code_XML = "&#xf1e8" });
            r.Add(new FontAwesomeModel() { Name = "Twitter", Code = "\uf099", Code_XML = "&#xf099" });
            r.Add(new FontAwesomeModel() { Name = "TwitterSquare", Code = "\uf081", Code_XML = "&#xf081" });
            r.Add(new FontAwesomeModel() { Name = "Typo3", Code = "\uf42b", Code_XML = "&#xf42b" });
            r.Add(new FontAwesomeModel() { Name = "Uber", Code = "\uf402", Code_XML = "&#xf402" });
            r.Add(new FontAwesomeModel() { Name = "Uikit", Code = "\uf403", Code_XML = "&#xf403" });
            r.Add(new FontAwesomeModel() { Name = "Umbrella", Code = "\uf0e9", Code_XML = "&#xf0e9" });
            r.Add(new FontAwesomeModel() { Name = "UmbrellaBeach", Code = "\uf5ca", Code_XML = "&#xf5ca" });
            r.Add(new FontAwesomeModel() { Name = "Underline", Code = "\uf0cd", Code_XML = "&#xf0cd" });
            r.Add(new FontAwesomeModel() { Name = "Undo", Code = "\uf0e2", Code_XML = "&#xf0e2" });
            r.Add(new FontAwesomeModel() { Name = "UndoAlt", Code = "\uf2ea", Code_XML = "&#xf2ea" });
            r.Add(new FontAwesomeModel() { Name = "Unicorn", Code = "\uf727", Code_XML = "&#xf727" });
            r.Add(new FontAwesomeModel() { Name = "Union", Code = "\uf6a2", Code_XML = "&#xf6a2" });
            r.Add(new FontAwesomeModel() { Name = "Uniregistry", Code = "\uf404", Code_XML = "&#xf404" });
            r.Add(new FontAwesomeModel() { Name = "UniversalAccess", Code = "\uf29a", Code_XML = "&#xf29a" });
            r.Add(new FontAwesomeModel() { Name = "University", Code = "\uf19c", Code_XML = "&#xf19c" });
            r.Add(new FontAwesomeModel() { Name = "Unlink", Code = "\uf127", Code_XML = "&#xf127" });
            r.Add(new FontAwesomeModel() { Name = "Unlock", Code = "\uf09c", Code_XML = "&#xf09c" });
            r.Add(new FontAwesomeModel() { Name = "UnlockAlt", Code = "\uf13e", Code_XML = "&#xf13e" });
            r.Add(new FontAwesomeModel() { Name = "Untappd", Code = "\uf405", Code_XML = "&#xf405" });
            r.Add(new FontAwesomeModel() { Name = "Upload", Code = "\uf093", Code_XML = "&#xf093" });
            r.Add(new FontAwesomeModel() { Name = "Usb", Code = "\uf287", Code_XML = "&#xf287" });
            r.Add(new FontAwesomeModel() { Name = "UsdCircle", Code = "\uf2e8", Code_XML = "&#xf2e8" });
            r.Add(new FontAwesomeModel() { Name = "UsdSquare", Code = "\uf2e9", Code_XML = "&#xf2e9" });
            r.Add(new FontAwesomeModel() { Name = "User", Code = "\uf007", Code_XML = "&#xf007" });
            r.Add(new FontAwesomeModel() { Name = "UserAlt", Code = "\uf406", Code_XML = "&#xf406" });
            r.Add(new FontAwesomeModel() { Name = "UserAltSlash", Code = "\uf4fa", Code_XML = "&#xf4fa" });
            r.Add(new FontAwesomeModel() { Name = "UserAstronaut", Code = "\uf4fb", Code_XML = "&#xf4fb" });
            r.Add(new FontAwesomeModel() { Name = "UserChart", Code = "\uf6a3", Code_XML = "&#xf6a3" });
            r.Add(new FontAwesomeModel() { Name = "UserCheck", Code = "\uf4fc", Code_XML = "&#xf4fc" });
            r.Add(new FontAwesomeModel() { Name = "UserCircle", Code = "\uf2bd", Code_XML = "&#xf2bd" });
            r.Add(new FontAwesomeModel() { Name = "UserClock", Code = "\uf4fd", Code_XML = "&#xf4fd" });
            r.Add(new FontAwesomeModel() { Name = "UserCog", Code = "\uf4fe", Code_XML = "&#xf4fe" });
            r.Add(new FontAwesomeModel() { Name = "UserCrown", Code = "\uf6a4", Code_XML = "&#xf6a4" });
            r.Add(new FontAwesomeModel() { Name = "UserEdit", Code = "\uf4ff", Code_XML = "&#xf4ff" });
            r.Add(new FontAwesomeModel() { Name = "UserFriends", Code = "\uf500", Code_XML = "&#xf500" });
            r.Add(new FontAwesomeModel() { Name = "UserGraduate", Code = "\uf501", Code_XML = "&#xf501" });
            r.Add(new FontAwesomeModel() { Name = "UserInjured", Code = "\uf728", Code_XML = "&#xf728" });
            r.Add(new FontAwesomeModel() { Name = "UserLock", Code = "\uf502", Code_XML = "&#xf502" });
            r.Add(new FontAwesomeModel() { Name = "UserMd", Code = "\uf0f0", Code_XML = "&#xf0f0" });
            r.Add(new FontAwesomeModel() { Name = "UserMinus", Code = "\uf503", Code_XML = "&#xf503" });
            r.Add(new FontAwesomeModel() { Name = "UserNinja", Code = "\uf504", Code_XML = "&#xf504" });
            r.Add(new FontAwesomeModel() { Name = "UserPlus", Code = "\uf234", Code_XML = "&#xf234" });
            r.Add(new FontAwesomeModel() { Name = "UserSecret", Code = "\uf21b", Code_XML = "&#xf21b" });
            r.Add(new FontAwesomeModel() { Name = "UserShield", Code = "\uf505", Code_XML = "&#xf505" });
            r.Add(new FontAwesomeModel() { Name = "UserSlash", Code = "\uf506", Code_XML = "&#xf506" });
            r.Add(new FontAwesomeModel() { Name = "UserTag", Code = "\uf507", Code_XML = "&#xf507" });
            r.Add(new FontAwesomeModel() { Name = "UserTie", Code = "\uf508", Code_XML = "&#xf508" });
            r.Add(new FontAwesomeModel() { Name = "UserTimes", Code = "\uf235", Code_XML = "&#xf235" });
            r.Add(new FontAwesomeModel() { Name = "Users", Code = "\uf0c0", Code_XML = "&#xf0c0" });
            r.Add(new FontAwesomeModel() { Name = "UsersClass", Code = "\uf63d", Code_XML = "&#xf63d" });
            r.Add(new FontAwesomeModel() { Name = "UsersCog", Code = "\uf509", Code_XML = "&#xf509" });
            r.Add(new FontAwesomeModel() { Name = "UsersCrown", Code = "\uf6a5", Code_XML = "&#xf6a5" });
            r.Add(new FontAwesomeModel() { Name = "Ussunnah", Code = "\uf407", Code_XML = "&#xf407" });
            r.Add(new FontAwesomeModel() { Name = "UtensilFork", Code = "\uf2e3", Code_XML = "&#xf2e3" });
            r.Add(new FontAwesomeModel() { Name = "UtensilKnife", Code = "\uf2e4", Code_XML = "&#xf2e4" });
            r.Add(new FontAwesomeModel() { Name = "UtensilSpoon", Code = "\uf2e5", Code_XML = "&#xf2e5" });
            r.Add(new FontAwesomeModel() { Name = "Utensils", Code = "\uf2e7", Code_XML = "&#xf2e7" });
            r.Add(new FontAwesomeModel() { Name = "UtensilsAlt", Code = "\uf2e6", Code_XML = "&#xf2e6" });
            r.Add(new FontAwesomeModel() { Name = "Vaadin", Code = "\uf408", Code_XML = "&#xf408" });
            r.Add(new FontAwesomeModel() { Name = "ValueAbsolute", Code = "\uf6a6", Code_XML = "&#xf6a6" });
            r.Add(new FontAwesomeModel() { Name = "VectorSquare", Code = "\uf5cb", Code_XML = "&#xf5cb" });
            r.Add(new FontAwesomeModel() { Name = "Venus", Code = "\uf221", Code_XML = "&#xf221" });
            r.Add(new FontAwesomeModel() { Name = "VenusDouble", Code = "\uf226", Code_XML = "&#xf226" });
            r.Add(new FontAwesomeModel() { Name = "VenusMars", Code = "\uf228", Code_XML = "&#xf228" });
            r.Add(new FontAwesomeModel() { Name = "Viacoin", Code = "\uf237", Code_XML = "&#xf237" });
            r.Add(new FontAwesomeModel() { Name = "Viadeo", Code = "\uf2a9", Code_XML = "&#xf2a9" });
            r.Add(new FontAwesomeModel() { Name = "ViadeoSquare", Code = "\uf2aa", Code_XML = "&#xf2aa" });
            r.Add(new FontAwesomeModel() { Name = "Vial", Code = "\uf492", Code_XML = "&#xf492" });
            r.Add(new FontAwesomeModel() { Name = "Vials", Code = "\uf493", Code_XML = "&#xf493" });
            r.Add(new FontAwesomeModel() { Name = "Viber", Code = "\uf409", Code_XML = "&#xf409" });
            r.Add(new FontAwesomeModel() { Name = "Video", Code = "\uf03d", Code_XML = "&#xf03d" });
            r.Add(new FontAwesomeModel() { Name = "VideoPlus", Code = "\uf4e1", Code_XML = "&#xf4e1" });
            r.Add(new FontAwesomeModel() { Name = "VideoSlash", Code = "\uf4e2", Code_XML = "&#xf4e2" });
            r.Add(new FontAwesomeModel() { Name = "Vihara", Code = "\uf6a7", Code_XML = "&#xf6a7" });
            r.Add(new FontAwesomeModel() { Name = "Vimeo", Code = "\uf40a", Code_XML = "&#xf40a" });
            r.Add(new FontAwesomeModel() { Name = "VimeoSquare", Code = "\uf194", Code_XML = "&#xf194" });
            r.Add(new FontAwesomeModel() { Name = "VimeoV", Code = "\uf27d", Code_XML = "&#xf27d" });
            r.Add(new FontAwesomeModel() { Name = "Vine", Code = "\uf1ca", Code_XML = "&#xf1ca" });
            r.Add(new FontAwesomeModel() { Name = "Vk", Code = "\uf189", Code_XML = "&#xf189" });
            r.Add(new FontAwesomeModel() { Name = "Vnv", Code = "\uf40b", Code_XML = "&#xf40b" });
            r.Add(new FontAwesomeModel() { Name = "Volcano", Code = "\uf770", Code_XML = "&#xf770" });
            r.Add(new FontAwesomeModel() { Name = "VolleyballBall", Code = "\uf45f", Code_XML = "&#xf45f" });
            r.Add(new FontAwesomeModel() { Name = "Volume", Code = "\uf6a8", Code_XML = "&#xf6a8" });
            r.Add(new FontAwesomeModel() { Name = "VolumeDown", Code = "\uf027", Code_XML = "&#xf027" });
            r.Add(new FontAwesomeModel() { Name = "VolumeMute", Code = "\uf6a9", Code_XML = "&#xf6a9" });
            r.Add(new FontAwesomeModel() { Name = "VolumeOff", Code = "\uf026", Code_XML = "&#xf026" });
            r.Add(new FontAwesomeModel() { Name = "VolumeSlash", Code = "\uf2e2", Code_XML = "&#xf2e2" });
            r.Add(new FontAwesomeModel() { Name = "VolumeUp", Code = "\uf028", Code_XML = "&#xf028" });
            r.Add(new FontAwesomeModel() { Name = "VoteNay", Code = "\uf771", Code_XML = "&#xf771" });
            r.Add(new FontAwesomeModel() { Name = "VoteYea", Code = "\uf772", Code_XML = "&#xf772" });
            r.Add(new FontAwesomeModel() { Name = "VrCardboard", Code = "\uf729", Code_XML = "&#xf729" });
            r.Add(new FontAwesomeModel() { Name = "Vuejs", Code = "\uf41f", Code_XML = "&#xf41f" });
            r.Add(new FontAwesomeModel() { Name = "Walking", Code = "\uf554", Code_XML = "&#xf554" });
            r.Add(new FontAwesomeModel() { Name = "Wallet", Code = "\uf555", Code_XML = "&#xf555" });
            r.Add(new FontAwesomeModel() { Name = "Wand", Code = "\uf72a", Code_XML = "&#xf72a" });
            r.Add(new FontAwesomeModel() { Name = "WandMagic", Code = "\uf72b", Code_XML = "&#xf72b" });
            r.Add(new FontAwesomeModel() { Name = "Warehouse", Code = "\uf494", Code_XML = "&#xf494" });
            r.Add(new FontAwesomeModel() { Name = "WarehouseAlt", Code = "\uf495", Code_XML = "&#xf495" });
            r.Add(new FontAwesomeModel() { Name = "Watch", Code = "\uf2e1", Code_XML = "&#xf2e1" });
            r.Add(new FontAwesomeModel() { Name = "WatchFitness", Code = "\uf63e", Code_XML = "&#xf63e" });
            r.Add(new FontAwesomeModel() { Name = "Water", Code = "\uf773", Code_XML = "&#xf773" });
            r.Add(new FontAwesomeModel() { Name = "WaterLower", Code = "\uf774", Code_XML = "&#xf774" });
            r.Add(new FontAwesomeModel() { Name = "WaterRise", Code = "\uf775", Code_XML = "&#xf775" });
            r.Add(new FontAwesomeModel() { Name = "Weebly", Code = "\uf5cc", Code_XML = "&#xf5cc" });
            r.Add(new FontAwesomeModel() { Name = "Weibo", Code = "\uf18a", Code_XML = "&#xf18a" });
            r.Add(new FontAwesomeModel() { Name = "Weight", Code = "\uf496", Code_XML = "&#xf496" });
            r.Add(new FontAwesomeModel() { Name = "WeightHanging", Code = "\uf5cd", Code_XML = "&#xf5cd" });
            r.Add(new FontAwesomeModel() { Name = "Weixin", Code = "\uf1d7", Code_XML = "&#xf1d7" });
            r.Add(new FontAwesomeModel() { Name = "Whale", Code = "\uf72c", Code_XML = "&#xf72c" });
            r.Add(new FontAwesomeModel() { Name = "Whatsapp", Code = "\uf232", Code_XML = "&#xf232" });
            r.Add(new FontAwesomeModel() { Name = "WhatsappSquare", Code = "\uf40c", Code_XML = "&#xf40c" });
            r.Add(new FontAwesomeModel() { Name = "Wheat", Code = "\uf72d", Code_XML = "&#xf72d" });
            r.Add(new FontAwesomeModel() { Name = "Wheelchair", Code = "\uf193", Code_XML = "&#xf193" });
            r.Add(new FontAwesomeModel() { Name = "Whistle", Code = "\uf460", Code_XML = "&#xf460" });
            r.Add(new FontAwesomeModel() { Name = "Whmcs", Code = "\uf40d", Code_XML = "&#xf40d" });
            r.Add(new FontAwesomeModel() { Name = "Wifi", Code = "\uf1eb", Code_XML = "&#xf1eb" });
            r.Add(new FontAwesomeModel() { Name = "Wifi1", Code = "\uf6aa", Code_XML = "&#xf6aa" });
            r.Add(new FontAwesomeModel() { Name = "Wifi2", Code = "\uf6ab", Code_XML = "&#xf6ab" });
            r.Add(new FontAwesomeModel() { Name = "WifiSlash", Code = "\uf6ac", Code_XML = "&#xf6ac" });
            r.Add(new FontAwesomeModel() { Name = "WikipediaW", Code = "\uf266", Code_XML = "&#xf266" });
            r.Add(new FontAwesomeModel() { Name = "Wind", Code = "\uf72e", Code_XML = "&#xf72e" });
            r.Add(new FontAwesomeModel() { Name = "WindWarning", Code = "\uf776", Code_XML = "&#xf776" });
            r.Add(new FontAwesomeModel() { Name = "Window", Code = "\uf40e", Code_XML = "&#xf40e" });
            r.Add(new FontAwesomeModel() { Name = "WindowAlt", Code = "\uf40f", Code_XML = "&#xf40f" });
            r.Add(new FontAwesomeModel() { Name = "WindowClose", Code = "\uf410", Code_XML = "&#xf410" });
            r.Add(new FontAwesomeModel() { Name = "WindowMaximize", Code = "\uf2d0", Code_XML = "&#xf2d0" });
            r.Add(new FontAwesomeModel() { Name = "WindowMinimize", Code = "\uf2d1", Code_XML = "&#xf2d1" });
            r.Add(new FontAwesomeModel() { Name = "WindowRestore", Code = "\uf2d2", Code_XML = "&#xf2d2" });
            r.Add(new FontAwesomeModel() { Name = "Windows", Code = "\uf17a", Code_XML = "&#xf17a" });
            r.Add(new FontAwesomeModel() { Name = "Windsock", Code = "\uf777", Code_XML = "&#xf777" });
            r.Add(new FontAwesomeModel() { Name = "WineBottle", Code = "\uf72f", Code_XML = "&#xf72f" });
            r.Add(new FontAwesomeModel() { Name = "WineGlass", Code = "\uf4e3", Code_XML = "&#xf4e3" });
            r.Add(new FontAwesomeModel() { Name = "WineGlassAlt", Code = "\uf5ce", Code_XML = "&#xf5ce" });
            r.Add(new FontAwesomeModel() { Name = "Wix", Code = "\uf5cf", Code_XML = "&#xf5cf" });
            r.Add(new FontAwesomeModel() { Name = "WizardsOfTheCoast", Code = "\uf730", Code_XML = "&#xf730" });
            r.Add(new FontAwesomeModel() { Name = "WolfPackBattalion", Code = "\uf514", Code_XML = "&#xf514" });
            r.Add(new FontAwesomeModel() { Name = "WonSign", Code = "\uf159", Code_XML = "&#xf159" });
            r.Add(new FontAwesomeModel() { Name = "Wordpress", Code = "\uf19a", Code_XML = "&#xf19a" });
            r.Add(new FontAwesomeModel() { Name = "WordpressSimple", Code = "\uf411", Code_XML = "&#xf411" });
            r.Add(new FontAwesomeModel() { Name = "Wpbeginner", Code = "\uf297", Code_XML = "&#xf297" });
            r.Add(new FontAwesomeModel() { Name = "Wpexplorer", Code = "\uf2de", Code_XML = "&#xf2de" });
            r.Add(new FontAwesomeModel() { Name = "Wpforms", Code = "\uf298", Code_XML = "&#xf298" });
            r.Add(new FontAwesomeModel() { Name = "Wpressr", Code = "\uf3e4", Code_XML = "&#xf3e4" });
            r.Add(new FontAwesomeModel() { Name = "Wrench", Code = "\uf0ad", Code_XML = "&#xf0ad" });
            r.Add(new FontAwesomeModel() { Name = "XRay", Code = "\uf497", Code_XML = "&#xf497" });
            r.Add(new FontAwesomeModel() { Name = "Xbox", Code = "\uf412", Code_XML = "&#xf412" });
            r.Add(new FontAwesomeModel() { Name = "Xing", Code = "\uf168", Code_XML = "&#xf168" });
            r.Add(new FontAwesomeModel() { Name = "XingSquare", Code = "\uf169", Code_XML = "&#xf169" });
            r.Add(new FontAwesomeModel() { Name = "YCombinator", Code = "\uf23b", Code_XML = "&#xf23b" });
            r.Add(new FontAwesomeModel() { Name = "Yahoo", Code = "\uf19e", Code_XML = "&#xf19e" });
            r.Add(new FontAwesomeModel() { Name = "Yandex", Code = "\uf413", Code_XML = "&#xf413" });
            r.Add(new FontAwesomeModel() { Name = "YandexInternational", Code = "\uf414", Code_XML = "&#xf414" });
            r.Add(new FontAwesomeModel() { Name = "Yelp", Code = "\uf1e9", Code_XML = "&#xf1e9" });
            r.Add(new FontAwesomeModel() { Name = "YenSign", Code = "\uf157", Code_XML = "&#xf157" });
            r.Add(new FontAwesomeModel() { Name = "YinYang", Code = "\uf6ad", Code_XML = "&#xf6ad" });
            r.Add(new FontAwesomeModel() { Name = "Yoast", Code = "\uf2b1", Code_XML = "&#xf2b1" });
            r.Add(new FontAwesomeModel() { Name = "Youtube", Code = "\uf167", Code_XML = "&#xf167" });
            r.Add(new FontAwesomeModel() { Name = "YoutubeSquare", Code = "\uf431", Code_XML = "&#xf431" });
            r.Add(new FontAwesomeModel() { Name = "Zhihu", Code = "\uf63f", Code_XML = "&#xf63f" });

            return r;
        }

        /// <summary>
        /// 在 .cs 中使用
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 在 xml / xaml 中使用
        /// </summary>
        public string Code_XML { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// The unicode values for all FontAwesome icons.
    /// <para/>
    /// See https://fontawesome.com/cheatsheet
    /// <para/>
    /// This code was automatically generated by FA2CS (https://github.com/matthewrdev/fa2cs).
    /// </summary>
    public static class FontAwesomeIcons
    {
        /// <summary>
        /// fa-500px unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/500px
        /// </summary>
        public const string FiveHundredPX = "\uf26e";

        /// <summary>
        /// fa-abacus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/abacus
        /// </summary>
        public const string Abacus = "\uf640";

        /// <summary>
        /// fa-accessible-icon unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/accessible-icon
        /// </summary>
        public const string AccessibleIcon = "\uf368";

        /// <summary>
        /// fa-accusoft unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/accusoft
        /// </summary>
        public const string Accusoft = "\uf369";

        /// <summary>
        /// fa-acorn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/acorn
        /// </summary>
        public const string Acorn = "\uf6ae";

        /// <summary>
        /// fa-acquisitions-incorporated unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/acquisitions-incorporated
        /// </summary>
        public const string AcquisitionsIncorporated = "\uf6af";

        /// <summary>
        /// fa-ad unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ad
        /// </summary>
        public const string Ad = "\uf641";

        /// <summary>
        /// fa-address-book unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/address-book
        /// </summary>
        public const string AddressBook = "\uf2b9";

        /// <summary>
        /// fa-address-card unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/address-card
        /// </summary>
        public const string AddressCard = "\uf2bb";

        /// <summary>
        /// fa-adjust unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/adjust
        /// </summary>
        public const string Adjust = "\uf042";

        /// <summary>
        /// fa-adn unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/adn
        /// </summary>
        public const string Adn = "\uf170";

        /// <summary>
        /// fa-adversal unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/adversal
        /// </summary>
        public const string Adversal = "\uf36a";

        /// <summary>
        /// fa-affiliatetheme unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/affiliatetheme
        /// </summary>
        public const string Affiliatetheme = "\uf36b";

        /// <summary>
        /// fa-air-freshener unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/air-freshener
        /// </summary>
        public const string AirFreshener = "\uf5d0";

        /// <summary>
        /// fa-alarm-clock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/alarm-clock
        /// </summary>
        public const string AlarmClock = "\uf34e";

        /// <summary>
        /// fa-algolia unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/algolia
        /// </summary>
        public const string Algolia = "\uf36c";

        /// <summary>
        /// fa-alicorn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/alicorn
        /// </summary>
        public const string Alicorn = "\uf6b0";

        /// <summary>
        /// fa-align-center unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/align-center
        /// </summary>
        public const string AlignCenter = "\uf037";

        /// <summary>
        /// fa-align-justify unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/align-justify
        /// </summary>
        public const string AlignJustify = "\uf039";

        /// <summary>
        /// fa-align-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/align-left
        /// </summary>
        public const string AlignLeft = "\uf036";

        /// <summary>
        /// fa-align-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/align-right
        /// </summary>
        public const string AlignRight = "\uf038";

        /// <summary>
        /// fa-alipay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/alipay
        /// </summary>
        public const string Alipay = "\uf642";

        /// <summary>
        /// fa-allergies unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/allergies
        /// </summary>
        public const string Allergies = "\uf461";

        /// <summary>
        /// fa-amazon unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/amazon
        /// </summary>
        public const string Amazon = "\uf270";

        /// <summary>
        /// fa-amazon-pay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/amazon-pay
        /// </summary>
        public const string AmazonPay = "\uf42c";

        /// <summary>
        /// fa-ambulance unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ambulance
        /// </summary>
        public const string Ambulance = "\uf0f9";

        /// <summary>
        /// fa-american-sign-language-interpreting unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/american-sign-language-interpreting
        /// </summary>
        public const string AmericanSignLanguageInterpreting = "\uf2a3";

        /// <summary>
        /// fa-amilia unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/amilia
        /// </summary>
        public const string Amilia = "\uf36d";

        /// <summary>
        /// fa-analytics unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/analytics
        /// </summary>
        public const string Analytics = "\uf643";

        /// <summary>
        /// fa-anchor unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/anchor
        /// </summary>
        public const string Anchor = "\uf13d";

        /// <summary>
        /// fa-android unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/android
        /// </summary>
        public const string Android = "\uf17b";

        /// <summary>
        /// fa-angellist unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/angellist
        /// </summary>
        public const string Angellist = "\uf209";

        /// <summary>
        /// fa-angle-double-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-double-down
        /// </summary>
        public const string AngleDoubleDown = "\uf103";

        /// <summary>
        /// fa-angle-double-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-double-left
        /// </summary>
        public const string AngleDoubleLeft = "\uf100";

        /// <summary>
        /// fa-angle-double-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-double-right
        /// </summary>
        public const string AngleDoubleRight = "\uf101";

        /// <summary>
        /// fa-angle-double-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-double-up
        /// </summary>
        public const string AngleDoubleUp = "\uf102";

        /// <summary>
        /// fa-angle-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-down
        /// </summary>
        public const string AngleDown = "\uf107";

        /// <summary>
        /// fa-angle-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-left
        /// </summary>
        public const string AngleLeft = "\uf104";

        /// <summary>
        /// fa-angle-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-right
        /// </summary>
        public const string AngleRight = "\uf105";

        /// <summary>
        /// fa-angle-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angle-up
        /// </summary>
        public const string AngleUp = "\uf106";

        /// <summary>
        /// fa-angry unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/angry
        /// </summary>
        public const string Angry = "\uf556";

        /// <summary>
        /// fa-angrycreative unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/angrycreative
        /// </summary>
        public const string Angrycreative = "\uf36e";

        /// <summary>
        /// fa-angular unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/angular
        /// </summary>
        public const string Angular = "\uf420";

        /// <summary>
        /// fa-ankh unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ankh
        /// </summary>
        public const string Ankh = "\uf644";

        /// <summary>
        /// fa-app-store unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/app-store
        /// </summary>
        public const string AppStore = "\uf36f";

        /// <summary>
        /// fa-app-store-ios unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/app-store-ios
        /// </summary>
        public const string AppStoreIos = "\uf370";

        /// <summary>
        /// fa-apper unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/apper
        /// </summary>
        public const string Apper = "\uf371";

        /// <summary>
        /// fa-apple unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/apple
        /// </summary>
        public const string Apple = "\uf179";

        /// <summary>
        /// fa-apple-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/apple-alt
        /// </summary>
        public const string AppleAlt = "\uf5d1";

        /// <summary>
        /// fa-apple-crate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/apple-crate
        /// </summary>
        public const string AppleCrate = "\uf6b1";

        /// <summary>
        /// fa-apple-pay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/apple-pay
        /// </summary>
        public const string ApplePay = "\uf415";

        /// <summary>
        /// fa-archive unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/archive
        /// </summary>
        public const string Archive = "\uf187";

        /// <summary>
        /// fa-archway unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/archway
        /// </summary>
        public const string Archway = "\uf557";

        /// <summary>
        /// fa-arrow-alt-circle-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-circle-down
        /// </summary>
        public const string ArrowAltCircleDown = "\uf358";

        /// <summary>
        /// fa-arrow-alt-circle-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-circle-left
        /// </summary>
        public const string ArrowAltCircleLeft = "\uf359";

        /// <summary>
        /// fa-arrow-alt-circle-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-circle-right
        /// </summary>
        public const string ArrowAltCircleRight = "\uf35a";

        /// <summary>
        /// fa-arrow-alt-circle-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-circle-up
        /// </summary>
        public const string ArrowAltCircleUp = "\uf35b";

        /// <summary>
        /// fa-arrow-alt-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-down
        /// </summary>
        public const string ArrowAltDown = "\uf354";

        /// <summary>
        /// fa-arrow-alt-from-bottom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-from-bottom
        /// </summary>
        public const string ArrowAltFromBottom = "\uf346";

        /// <summary>
        /// fa-arrow-alt-from-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-from-left
        /// </summary>
        public const string ArrowAltFromLeft = "\uf347";

        /// <summary>
        /// fa-arrow-alt-from-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-from-right
        /// </summary>
        public const string ArrowAltFromRight = "\uf348";

        /// <summary>
        /// fa-arrow-alt-from-top unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-from-top
        /// </summary>
        public const string ArrowAltFromTop = "\uf349";

        /// <summary>
        /// fa-arrow-alt-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-left
        /// </summary>
        public const string ArrowAltLeft = "\uf355";

        /// <summary>
        /// fa-arrow-alt-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-right
        /// </summary>
        public const string ArrowAltRight = "\uf356";

        /// <summary>
        /// fa-arrow-alt-square-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-square-down
        /// </summary>
        public const string ArrowAltSquareDown = "\uf350";

        /// <summary>
        /// fa-arrow-alt-square-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-square-left
        /// </summary>
        public const string ArrowAltSquareLeft = "\uf351";

        /// <summary>
        /// fa-arrow-alt-square-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-square-right
        /// </summary>
        public const string ArrowAltSquareRight = "\uf352";

        /// <summary>
        /// fa-arrow-alt-square-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-square-up
        /// </summary>
        public const string ArrowAltSquareUp = "\uf353";

        /// <summary>
        /// fa-arrow-alt-to-bottom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-to-bottom
        /// </summary>
        public const string ArrowAltToBottom = "\uf34a";

        /// <summary>
        /// fa-arrow-alt-to-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-to-left
        /// </summary>
        public const string ArrowAltToLeft = "\uf34b";

        /// <summary>
        /// fa-arrow-alt-to-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-to-right
        /// </summary>
        public const string ArrowAltToRight = "\uf34c";

        /// <summary>
        /// fa-arrow-alt-to-top unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-to-top
        /// </summary>
        public const string ArrowAltToTop = "\uf34d";

        /// <summary>
        /// fa-arrow-alt-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-alt-up
        /// </summary>
        public const string ArrowAltUp = "\uf357";

        /// <summary>
        /// fa-arrow-circle-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-circle-down
        /// </summary>
        public const string ArrowCircleDown = "\uf0ab";

        /// <summary>
        /// fa-arrow-circle-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-circle-left
        /// </summary>
        public const string ArrowCircleLeft = "\uf0a8";

        /// <summary>
        /// fa-arrow-circle-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-circle-right
        /// </summary>
        public const string ArrowCircleRight = "\uf0a9";

        /// <summary>
        /// fa-arrow-circle-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-circle-up
        /// </summary>
        public const string ArrowCircleUp = "\uf0aa";

        /// <summary>
        /// fa-arrow-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-down
        /// </summary>
        public const string ArrowDown = "\uf063";

        /// <summary>
        /// fa-arrow-from-bottom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-from-bottom
        /// </summary>
        public const string ArrowFromBottom = "\uf342";

        /// <summary>
        /// fa-arrow-from-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-from-left
        /// </summary>
        public const string ArrowFromLeft = "\uf343";

        /// <summary>
        /// fa-arrow-from-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-from-right
        /// </summary>
        public const string ArrowFromRight = "\uf344";

        /// <summary>
        /// fa-arrow-from-top unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-from-top
        /// </summary>
        public const string ArrowFromTop = "\uf345";

        /// <summary>
        /// fa-arrow-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-left
        /// </summary>
        public const string ArrowLeft = "\uf060";

        /// <summary>
        /// fa-arrow-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-right
        /// </summary>
        public const string ArrowRight = "\uf061";

        /// <summary>
        /// fa-arrow-square-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-square-down
        /// </summary>
        public const string ArrowSquareDown = "\uf339";

        /// <summary>
        /// fa-arrow-square-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-square-left
        /// </summary>
        public const string ArrowSquareLeft = "\uf33a";

        /// <summary>
        /// fa-arrow-square-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-square-right
        /// </summary>
        public const string ArrowSquareRight = "\uf33b";

        /// <summary>
        /// fa-arrow-square-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-square-up
        /// </summary>
        public const string ArrowSquareUp = "\uf33c";

        /// <summary>
        /// fa-arrow-to-bottom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-to-bottom
        /// </summary>
        public const string ArrowToBottom = "\uf33d";

        /// <summary>
        /// fa-arrow-to-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-to-left
        /// </summary>
        public const string ArrowToLeft = "\uf33e";

        /// <summary>
        /// fa-arrow-to-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-to-right
        /// </summary>
        public const string ArrowToRight = "\uf340";

        /// <summary>
        /// fa-arrow-to-top unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-to-top
        /// </summary>
        public const string ArrowToTop = "\uf341";

        /// <summary>
        /// fa-arrow-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrow-up
        /// </summary>
        public const string ArrowUp = "\uf062";

        /// <summary>
        /// fa-arrows unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrows
        /// </summary>
        public const string Arrows = "\uf047";

        /// <summary>
        /// fa-arrows-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrows-alt
        /// </summary>
        public const string ArrowsAlt = "\uf0b2";

        /// <summary>
        /// fa-arrows-alt-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrows-alt-h
        /// </summary>
        public const string ArrowsAltH = "\uf337";

        /// <summary>
        /// fa-arrows-alt-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/arrows-alt-v
        /// </summary>
        public const string ArrowsAltV = "\uf338";

        /// <summary>
        /// fa-arrows-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrows-h
        /// </summary>
        public const string ArrowsH = "\uf07e";

        /// <summary>
        /// fa-arrows-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/arrows-v
        /// </summary>
        public const string ArrowsV = "\uf07d";

        /// <summary>
        /// fa-assistive-listening-systems unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/assistive-listening-systems
        /// </summary>
        public const string AssistiveListeningSystems = "\uf2a2";

        /// <summary>
        /// fa-asterisk unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/asterisk
        /// </summary>
        public const string Asterisk = "\uf069";

        /// <summary>
        /// fa-asymmetrik unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/asymmetrik
        /// </summary>
        public const string Asymmetrik = "\uf372";

        /// <summary>
        /// fa-at unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/at
        /// </summary>
        public const string At = "\uf1fa";

        /// <summary>
        /// fa-atlas unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/atlas
        /// </summary>
        public const string Atlas = "\uf558";

        /// <summary>
        /// fa-atom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/atom
        /// </summary>
        public const string Atom = "\uf5d2";

        /// <summary>
        /// fa-atom-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/atom-alt
        /// </summary>
        public const string AtomAlt = "\uf5d3";

        /// <summary>
        /// fa-audible unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/audible
        /// </summary>
        public const string Audible = "\uf373";

        /// <summary>
        /// fa-audio-description unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/audio-description
        /// </summary>
        public const string AudioDescription = "\uf29e";

        /// <summary>
        /// fa-autoprefixer unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/autoprefixer
        /// </summary>
        public const string Autoprefixer = "\uf41c";

        /// <summary>
        /// fa-avianex unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/avianex
        /// </summary>
        public const string Avianex = "\uf374";

        /// <summary>
        /// fa-aviato unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/aviato
        /// </summary>
        public const string Aviato = "\uf421";

        /// <summary>
        /// fa-award unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/award
        /// </summary>
        public const string Award = "\uf559";

        /// <summary>
        /// fa-aws unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/aws
        /// </summary>
        public const string Aws = "\uf375";

        /// <summary>
        /// fa-axe unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/axe
        /// </summary>
        public const string Axe = "\uf6b2";

        /// <summary>
        /// fa-axe-battle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/axe-battle
        /// </summary>
        public const string AxeBattle = "\uf6b3";

        /// <summary>
        /// fa-backpack unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/backpack
        /// </summary>
        public const string Backpack = "\uf5d4";

        /// <summary>
        /// fa-backspace unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/backspace
        /// </summary>
        public const string Backspace = "\uf55a";

        /// <summary>
        /// fa-backward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/backward
        /// </summary>
        public const string Backward = "\uf04a";

        /// <summary>
        /// fa-badge unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/badge
        /// </summary>
        public const string Badge = "\uf335";

        /// <summary>
        /// fa-badge-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/badge-check
        /// </summary>
        public const string BadgeCheck = "\uf336";

        /// <summary>
        /// fa-badge-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/badge-dollar
        /// </summary>
        public const string BadgeDollar = "\uf645";

        /// <summary>
        /// fa-badge-percent unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/badge-percent
        /// </summary>
        public const string BadgePercent = "\uf646";

        /// <summary>
        /// fa-badger-honey unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/badger-honey
        /// </summary>
        public const string BadgerHoney = "\uf6b4";

        /// <summary>
        /// fa-balance-scale unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/balance-scale
        /// </summary>
        public const string BalanceScale = "\uf24e";

        /// <summary>
        /// fa-balance-scale-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/balance-scale-left
        /// </summary>
        public const string BalanceScaleLeft = "\uf515";

        /// <summary>
        /// fa-balance-scale-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/balance-scale-right
        /// </summary>
        public const string BalanceScaleRight = "\uf516";

        /// <summary>
        /// fa-ballot unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ballot
        /// </summary>
        public const string Ballot = "\uf732";

        /// <summary>
        /// fa-ballot-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ballot-check
        /// </summary>
        public const string BallotCheck = "\uf733";

        /// <summary>
        /// fa-ban unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ban
        /// </summary>
        public const string Ban = "\uf05e";

        /// <summary>
        /// fa-band-aid unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/band-aid
        /// </summary>
        public const string BandAid = "\uf462";

        /// <summary>
        /// fa-bandcamp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bandcamp
        /// </summary>
        public const string Bandcamp = "\uf2d5";

        /// <summary>
        /// fa-barcode unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/barcode
        /// </summary>
        public const string Barcode = "\uf02a";

        /// <summary>
        /// fa-barcode-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/barcode-alt
        /// </summary>
        public const string BarcodeAlt = "\uf463";

        /// <summary>
        /// fa-barcode-read unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/barcode-read
        /// </summary>
        public const string BarcodeRead = "\uf464";

        /// <summary>
        /// fa-barcode-scan unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/barcode-scan
        /// </summary>
        public const string BarcodeScan = "\uf465";

        /// <summary>
        /// fa-bars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bars
        /// </summary>
        public const string Bars = "\uf0c9";

        /// <summary>
        /// fa-baseball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/baseball
        /// </summary>
        public const string Baseball = "\uf432";

        /// <summary>
        /// fa-baseball-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/baseball-ball
        /// </summary>
        public const string BaseballBall = "\uf433";

        /// <summary>
        /// fa-basketball-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/basketball-ball
        /// </summary>
        public const string BasketballBall = "\uf434";

        /// <summary>
        /// fa-basketball-hoop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/basketball-hoop
        /// </summary>
        public const string BasketballHoop = "\uf435";

        /// <summary>
        /// fa-bat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bat
        /// </summary>
        public const string Bat = "\uf6b5";

        /// <summary>
        /// fa-bath unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bath
        /// </summary>
        public const string Bath = "\uf2cd";

        /// <summary>
        /// fa-battery-bolt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/battery-bolt
        /// </summary>
        public const string BatteryBolt = "\uf376";

        /// <summary>
        /// fa-battery-empty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/battery-empty
        /// </summary>
        public const string BatteryEmpty = "\uf244";

        /// <summary>
        /// fa-battery-full unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/battery-full
        /// </summary>
        public const string BatteryFull = "\uf240";

        /// <summary>
        /// fa-battery-half unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/battery-half
        /// </summary>
        public const string BatteryHalf = "\uf242";

        /// <summary>
        /// fa-battery-quarter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/battery-quarter
        /// </summary>
        public const string BatteryQuarter = "\uf243";

        /// <summary>
        /// fa-battery-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/battery-slash
        /// </summary>
        public const string BatterySlash = "\uf377";

        /// <summary>
        /// fa-battery-three-quarters unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/battery-three-quarters
        /// </summary>
        public const string BatteryThreeQuarters = "\uf241";

        /// <summary>
        /// fa-bed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bed
        /// </summary>
        public const string Bed = "\uf236";

        /// <summary>
        /// fa-beer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/beer
        /// </summary>
        public const string Beer = "\uf0fc";

        /// <summary>
        /// fa-behance unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/behance
        /// </summary>
        public const string Behance = "\uf1b4";

        /// <summary>
        /// fa-behance-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/behance-square
        /// </summary>
        public const string BehanceSquare = "\uf1b5";

        /// <summary>
        /// fa-bell unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bell
        /// </summary>
        public const string Bell = "\uf0f3";

        /// <summary>
        /// fa-bell-school unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bell-school
        /// </summary>
        public const string BellSchool = "\uf5d5";

        /// <summary>
        /// fa-bell-school-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bell-school-slash
        /// </summary>
        public const string BellSchoolSlash = "\uf5d6";

        /// <summary>
        /// fa-bell-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bell-slash
        /// </summary>
        public const string BellSlash = "\uf1f6";

        /// <summary>
        /// fa-bezier-curve unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bezier-curve
        /// </summary>
        public const string BezierCurve = "\uf55b";

        /// <summary>
        /// fa-bible unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bible
        /// </summary>
        public const string Bible = "\uf647";

        /// <summary>
        /// fa-bicycle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bicycle
        /// </summary>
        public const string Bicycle = "\uf206";

        /// <summary>
        /// fa-bimobject unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bimobject
        /// </summary>
        public const string Bimobject = "\uf378";

        /// <summary>
        /// fa-binoculars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/binoculars
        /// </summary>
        public const string Binoculars = "\uf1e5";

        /// <summary>
        /// fa-birthday-cake unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/birthday-cake
        /// </summary>
        public const string BirthdayCake = "\uf1fd";

        /// <summary>
        /// fa-bitbucket unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bitbucket
        /// </summary>
        public const string Bitbucket = "\uf171";

        /// <summary>
        /// fa-bitcoin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bitcoin
        /// </summary>
        public const string Bitcoin = "\uf379";

        /// <summary>
        /// fa-bity unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bity
        /// </summary>
        public const string Bity = "\uf37a";

        /// <summary>
        /// fa-black-tie unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/black-tie
        /// </summary>
        public const string BlackTie = "\uf27e";

        /// <summary>
        /// fa-blackberry unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/blackberry
        /// </summary>
        public const string Blackberry = "\uf37b";

        /// <summary>
        /// fa-blanket unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/blanket
        /// </summary>
        public const string Blanket = "\uf498";

        /// <summary>
        /// fa-blender unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/blender
        /// </summary>
        public const string Blender = "\uf517";

        /// <summary>
        /// fa-blender-phone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/blender-phone
        /// </summary>
        public const string BlenderPhone = "\uf6b6";

        /// <summary>
        /// fa-blind unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/blind
        /// </summary>
        public const string Blind = "\uf29d";

        /// <summary>
        /// fa-blogger unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/blogger
        /// </summary>
        public const string Blogger = "\uf37c";

        /// <summary>
        /// fa-blogger-b unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/blogger-b
        /// </summary>
        public const string BloggerB = "\uf37d";

        /// <summary>
        /// fa-bluetooth unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bluetooth
        /// </summary>
        public const string Bluetooth = "\uf293";

        /// <summary>
        /// fa-bluetooth-b unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/bluetooth-b
        /// </summary>
        public const string BluetoothB = "\uf294";

        /// <summary>
        /// fa-bold unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bold
        /// </summary>
        public const string Bold = "\uf032";

        /// <summary>
        /// fa-bolt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bolt
        /// </summary>
        public const string Bolt = "\uf0e7";

        /// <summary>
        /// fa-bomb unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bomb
        /// </summary>
        public const string Bomb = "\uf1e2";

        /// <summary>
        /// fa-bone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bone
        /// </summary>
        public const string Bone = "\uf5d7";

        /// <summary>
        /// fa-bone-break unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bone-break
        /// </summary>
        public const string BoneBreak = "\uf5d8";

        /// <summary>
        /// fa-bong unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bong
        /// </summary>
        public const string Bong = "\uf55c";

        /// <summary>
        /// fa-book unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/book
        /// </summary>
        public const string Book = "\uf02d";

        /// <summary>
        /// fa-book-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/book-alt
        /// </summary>
        public const string BookAlt = "\uf5d9";

        /// <summary>
        /// fa-book-dead unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/book-dead
        /// </summary>
        public const string BookDead = "\uf6b7";

        /// <summary>
        /// fa-book-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/book-heart
        /// </summary>
        public const string BookHeart = "\uf499";

        /// <summary>
        /// fa-book-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/book-open
        /// </summary>
        public const string BookOpen = "\uf518";

        /// <summary>
        /// fa-book-reader unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/book-reader
        /// </summary>
        public const string BookReader = "\uf5da";

        /// <summary>
        /// fa-book-spells unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/book-spells
        /// </summary>
        public const string BookSpells = "\uf6b8";

        /// <summary>
        /// fa-bookmark unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bookmark
        /// </summary>
        public const string Bookmark = "\uf02e";

        /// <summary>
        /// fa-books unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/books
        /// </summary>
        public const string Books = "\uf5db";

        /// <summary>
        /// fa-booth-curtain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/booth-curtain
        /// </summary>
        public const string BoothCurtain = "\uf734";

        /// <summary>
        /// fa-bow-arrow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bow-arrow
        /// </summary>
        public const string BowArrow = "\uf6b9";

        /// <summary>
        /// fa-bowling-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bowling-ball
        /// </summary>
        public const string BowlingBall = "\uf436";

        /// <summary>
        /// fa-bowling-pins unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bowling-pins
        /// </summary>
        public const string BowlingPins = "\uf437";

        /// <summary>
        /// fa-box unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/box
        /// </summary>
        public const string Box = "\uf466";

        /// <summary>
        /// fa-box-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-alt
        /// </summary>
        public const string BoxAlt = "\uf49a";

        /// <summary>
        /// fa-box-ballot unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-ballot
        /// </summary>
        public const string BoxBallot = "\uf735";

        /// <summary>
        /// fa-box-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-check
        /// </summary>
        public const string BoxCheck = "\uf467";

        /// <summary>
        /// fa-box-fragile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-fragile
        /// </summary>
        public const string BoxFragile = "\uf49b";

        /// <summary>
        /// fa-box-full unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-full
        /// </summary>
        public const string BoxFull = "\uf49c";

        /// <summary>
        /// fa-box-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-heart
        /// </summary>
        public const string BoxHeart = "\uf49d";

        /// <summary>
        /// fa-box-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/box-open
        /// </summary>
        public const string BoxOpen = "\uf49e";

        /// <summary>
        /// fa-box-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-up
        /// </summary>
        public const string BoxUp = "\uf49f";

        /// <summary>
        /// fa-box-usd unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/box-usd
        /// </summary>
        public const string BoxUsd = "\uf4a0";

        /// <summary>
        /// fa-boxes unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/boxes
        /// </summary>
        public const string Boxes = "\uf468";

        /// <summary>
        /// fa-boxes-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/boxes-alt
        /// </summary>
        public const string BoxesAlt = "\uf4a1";

        /// <summary>
        /// fa-boxing-glove unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/boxing-glove
        /// </summary>
        public const string BoxingGlove = "\uf438";

        /// <summary>
        /// fa-braille unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/braille
        /// </summary>
        public const string Braille = "\uf2a1";

        /// <summary>
        /// fa-brain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/brain
        /// </summary>
        public const string Brain = "\uf5dc";

        /// <summary>
        /// fa-briefcase unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/briefcase
        /// </summary>
        public const string Briefcase = "\uf0b1";

        /// <summary>
        /// fa-briefcase-medical unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/briefcase-medical
        /// </summary>
        public const string BriefcaseMedical = "\uf469";

        /// <summary>
        /// fa-broadcast-tower unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/broadcast-tower
        /// </summary>
        public const string BroadcastTower = "\uf519";

        /// <summary>
        /// fa-broom unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/broom
        /// </summary>
        public const string Broom = "\uf51a";

        /// <summary>
        /// fa-browser unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/browser
        /// </summary>
        public const string Browser = "\uf37e";

        /// <summary>
        /// fa-brush unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/brush
        /// </summary>
        public const string Brush = "\uf55d";

        /// <summary>
        /// fa-btc unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/btc
        /// </summary>
        public const string Btc = "\uf15a";

        /// <summary>
        /// fa-bug unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bug
        /// </summary>
        public const string Bug = "\uf188";

        /// <summary>
        /// fa-building unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/building
        /// </summary>
        public const string Building = "\uf1ad";

        /// <summary>
        /// fa-bullhorn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bullhorn
        /// </summary>
        public const string Bullhorn = "\uf0a1";

        /// <summary>
        /// fa-bullseye unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bullseye
        /// </summary>
        public const string Bullseye = "\uf140";

        /// <summary>
        /// fa-bullseye-arrow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bullseye-arrow
        /// </summary>
        public const string BullseyeArrow = "\uf648";

        /// <summary>
        /// fa-bullseye-pointer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bullseye-pointer
        /// </summary>
        public const string BullseyePointer = "\uf649";

        /// <summary>
        /// fa-burn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/burn
        /// </summary>
        public const string Burn = "\uf46a";

        /// <summary>
        /// fa-buromobelexperte unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/buromobelexperte
        /// </summary>
        public const string Buromobelexperte = "\uf37f";

        /// <summary>
        /// fa-bus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bus
        /// </summary>
        public const string Bus = "\uf207";

        /// <summary>
        /// fa-bus-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/bus-alt
        /// </summary>
        public const string BusAlt = "\uf55e";

        /// <summary>
        /// fa-bus-school unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/bus-school
        /// </summary>
        public const string BusSchool = "\uf5dd";

        /// <summary>
        /// fa-business-time unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/business-time
        /// </summary>
        public const string BusinessTime = "\uf64a";

        /// <summary>
        /// fa-buysellads unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/buysellads
        /// </summary>
        public const string Buysellads = "\uf20d";

        /// <summary>
        /// fa-cabinet-filing unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cabinet-filing
        /// </summary>
        public const string CabinetFiling = "\uf64b";

        /// <summary>
        /// fa-calculator unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calculator
        /// </summary>
        public const string Calculator = "\uf1ec";

        /// <summary>
        /// fa-calculator-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/calculator-alt
        /// </summary>
        public const string CalculatorAlt = "\uf64c";

        /// <summary>
        /// fa-calendar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar
        /// </summary>
        public const string Calendar = "\uf133";

        /// <summary>
        /// fa-calendar-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-alt
        /// </summary>
        public const string CalendarAlt = "\uf073";

        /// <summary>
        /// fa-calendar-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-check
        /// </summary>
        public const string CalendarCheck = "\uf274";

        /// <summary>
        /// fa-calendar-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-edit
        /// </summary>
        public const string CalendarEdit = "\uf333";

        /// <summary>
        /// fa-calendar-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-exclamation
        /// </summary>
        public const string CalendarExclamation = "\uf334";

        /// <summary>
        /// fa-calendar-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-minus
        /// </summary>
        public const string CalendarMinus = "\uf272";

        /// <summary>
        /// fa-calendar-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-plus
        /// </summary>
        public const string CalendarPlus = "\uf271";

        /// <summary>
        /// fa-calendar-star unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-star
        /// </summary>
        public const string CalendarStar = "\uf736";

        /// <summary>
        /// fa-calendar-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/calendar-times
        /// </summary>
        public const string CalendarTimes = "\uf273";

        /// <summary>
        /// fa-camera unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/camera
        /// </summary>
        public const string Camera = "\uf030";

        /// <summary>
        /// fa-camera-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/camera-alt
        /// </summary>
        public const string CameraAlt = "\uf332";

        /// <summary>
        /// fa-camera-retro unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/camera-retro
        /// </summary>
        public const string CameraRetro = "\uf083";

        /// <summary>
        /// fa-campfire unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/campfire
        /// </summary>
        public const string Campfire = "\uf6ba";

        /// <summary>
        /// fa-campground unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/campground
        /// </summary>
        public const string Campground = "\uf6bb";

        /// <summary>
        /// fa-candle-holder unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/candle-holder
        /// </summary>
        public const string CandleHolder = "\uf6bc";

        /// <summary>
        /// fa-candy-corn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/candy-corn
        /// </summary>
        public const string CandyCorn = "\uf6bd";

        /// <summary>
        /// fa-cannabis unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cannabis
        /// </summary>
        public const string Cannabis = "\uf55f";

        /// <summary>
        /// fa-capsules unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/capsules
        /// </summary>
        public const string Capsules = "\uf46b";

        /// <summary>
        /// fa-car unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/car
        /// </summary>
        public const string Car = "\uf1b9";

        /// <summary>
        /// fa-car-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/car-alt
        /// </summary>
        public const string CarAlt = "\uf5de";

        /// <summary>
        /// fa-car-battery unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/car-battery
        /// </summary>
        public const string CarBattery = "\uf5df";

        /// <summary>
        /// fa-car-bump unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/car-bump
        /// </summary>
        public const string CarBump = "\uf5e0";

        /// <summary>
        /// fa-car-crash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/car-crash
        /// </summary>
        public const string CarCrash = "\uf5e1";

        /// <summary>
        /// fa-car-garage unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/car-garage
        /// </summary>
        public const string CarGarage = "\uf5e2";

        /// <summary>
        /// fa-car-mechanic unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/car-mechanic
        /// </summary>
        public const string CarMechanic = "\uf5e3";

        /// <summary>
        /// fa-car-side unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/car-side
        /// </summary>
        public const string CarSide = "\uf5e4";

        /// <summary>
        /// fa-car-tilt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/car-tilt
        /// </summary>
        public const string CarTilt = "\uf5e5";

        /// <summary>
        /// fa-car-wash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/car-wash
        /// </summary>
        public const string CarWash = "\uf5e6";

        /// <summary>
        /// fa-caret-circle-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/caret-circle-down
        /// </summary>
        public const string CaretCircleDown = "\uf32d";

        /// <summary>
        /// fa-caret-circle-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/caret-circle-left
        /// </summary>
        public const string CaretCircleLeft = "\uf32e";

        /// <summary>
        /// fa-caret-circle-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/caret-circle-right
        /// </summary>
        public const string CaretCircleRight = "\uf330";

        /// <summary>
        /// fa-caret-circle-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/caret-circle-up
        /// </summary>
        public const string CaretCircleUp = "\uf331";

        /// <summary>
        /// fa-caret-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-down
        /// </summary>
        public const string CaretDown = "\uf0d7";

        /// <summary>
        /// fa-caret-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-left
        /// </summary>
        public const string CaretLeft = "\uf0d9";

        /// <summary>
        /// fa-caret-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-right
        /// </summary>
        public const string CaretRight = "\uf0da";

        /// <summary>
        /// fa-caret-square-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-square-down
        /// </summary>
        public const string CaretSquareDown = "\uf150";

        /// <summary>
        /// fa-caret-square-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-square-left
        /// </summary>
        public const string CaretSquareLeft = "\uf191";

        /// <summary>
        /// fa-caret-square-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-square-right
        /// </summary>
        public const string CaretSquareRight = "\uf152";

        /// <summary>
        /// fa-caret-square-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-square-up
        /// </summary>
        public const string CaretSquareUp = "\uf151";

        /// <summary>
        /// fa-caret-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/caret-up
        /// </summary>
        public const string CaretUp = "\uf0d8";

        /// <summary>
        /// fa-cart-arrow-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cart-arrow-down
        /// </summary>
        public const string CartArrowDown = "\uf218";

        /// <summary>
        /// fa-cart-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cart-plus
        /// </summary>
        public const string CartPlus = "\uf217";

        /// <summary>
        /// fa-cat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cat
        /// </summary>
        public const string Cat = "\uf6be";

        /// <summary>
        /// fa-cauldron unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cauldron
        /// </summary>
        public const string Cauldron = "\uf6bf";

        /// <summary>
        /// fa-cc-amazon-pay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-amazon-pay
        /// </summary>
        public const string CcAmazonPay = "\uf42d";

        /// <summary>
        /// fa-cc-amex unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-amex
        /// </summary>
        public const string CcAmex = "\uf1f3";

        /// <summary>
        /// fa-cc-apple-pay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-apple-pay
        /// </summary>
        public const string CcApplePay = "\uf416";

        /// <summary>
        /// fa-cc-diners-club unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-diners-club
        /// </summary>
        public const string CcDinersClub = "\uf24c";

        /// <summary>
        /// fa-cc-discover unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-discover
        /// </summary>
        public const string CcDiscover = "\uf1f2";

        /// <summary>
        /// fa-cc-jcb unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-jcb
        /// </summary>
        public const string CcJcb = "\uf24b";

        /// <summary>
        /// fa-cc-mastercard unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-mastercard
        /// </summary>
        public const string CcMastercard = "\uf1f1";

        /// <summary>
        /// fa-cc-paypal unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-paypal
        /// </summary>
        public const string CcPaypal = "\uf1f4";

        /// <summary>
        /// fa-cc-stripe unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-stripe
        /// </summary>
        public const string CcStripe = "\uf1f5";

        /// <summary>
        /// fa-cc-visa unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cc-visa
        /// </summary>
        public const string CcVisa = "\uf1f0";

        /// <summary>
        /// fa-centercode unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/centercode
        /// </summary>
        public const string Centercode = "\uf380";

        /// <summary>
        /// fa-certificate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/certificate
        /// </summary>
        public const string Certificate = "\uf0a3";

        /// <summary>
        /// fa-chair unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chair
        /// </summary>
        public const string Chair = "\uf6c0";

        /// <summary>
        /// fa-chair-office unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chair-office
        /// </summary>
        public const string ChairOffice = "\uf6c1";

        /// <summary>
        /// fa-chalkboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chalkboard
        /// </summary>
        public const string Chalkboard = "\uf51b";

        /// <summary>
        /// fa-chalkboard-teacher unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chalkboard-teacher
        /// </summary>
        public const string ChalkboardTeacher = "\uf51c";

        /// <summary>
        /// fa-charging-station unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/charging-station
        /// </summary>
        public const string ChargingStation = "\uf5e7";

        /// <summary>
        /// fa-chart-area unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chart-area
        /// </summary>
        public const string ChartArea = "\uf1fe";

        /// <summary>
        /// fa-chart-bar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chart-bar
        /// </summary>
        public const string ChartBar = "\uf080";

        /// <summary>
        /// fa-chart-line unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chart-line
        /// </summary>
        public const string ChartLine = "\uf201";

        /// <summary>
        /// fa-chart-line-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chart-line-down
        /// </summary>
        public const string ChartLineDown = "\uf64d";

        /// <summary>
        /// fa-chart-pie unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chart-pie
        /// </summary>
        public const string ChartPie = "\uf200";

        /// <summary>
        /// fa-chart-pie-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chart-pie-alt
        /// </summary>
        public const string ChartPieAlt = "\uf64e";

        /// <summary>
        /// fa-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/check
        /// </summary>
        public const string Check = "\uf00c";

        /// <summary>
        /// fa-check-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/check-circle
        /// </summary>
        public const string CheckCircle = "\uf058";

        /// <summary>
        /// fa-check-double unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/check-double
        /// </summary>
        public const string CheckDouble = "\uf560";

        /// <summary>
        /// fa-check-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/check-square
        /// </summary>
        public const string CheckSquare = "\uf14a";

        /// <summary>
        /// fa-chess unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess
        /// </summary>
        public const string Chess = "\uf439";

        /// <summary>
        /// fa-chess-bishop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-bishop
        /// </summary>
        public const string ChessBishop = "\uf43a";

        /// <summary>
        /// fa-chess-bishop-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-bishop-alt
        /// </summary>
        public const string ChessBishopAlt = "\uf43b";

        /// <summary>
        /// fa-chess-board unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-board
        /// </summary>
        public const string ChessBoard = "\uf43c";

        /// <summary>
        /// fa-chess-clock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-clock
        /// </summary>
        public const string ChessClock = "\uf43d";

        /// <summary>
        /// fa-chess-clock-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-clock-alt
        /// </summary>
        public const string ChessClockAlt = "\uf43e";

        /// <summary>
        /// fa-chess-king unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-king
        /// </summary>
        public const string ChessKing = "\uf43f";

        /// <summary>
        /// fa-chess-king-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-king-alt
        /// </summary>
        public const string ChessKingAlt = "\uf440";

        /// <summary>
        /// fa-chess-knight unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-knight
        /// </summary>
        public const string ChessKnight = "\uf441";

        /// <summary>
        /// fa-chess-knight-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-knight-alt
        /// </summary>
        public const string ChessKnightAlt = "\uf442";

        /// <summary>
        /// fa-chess-pawn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-pawn
        /// </summary>
        public const string ChessPawn = "\uf443";

        /// <summary>
        /// fa-chess-pawn-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-pawn-alt
        /// </summary>
        public const string ChessPawnAlt = "\uf444";

        /// <summary>
        /// fa-chess-queen unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-queen
        /// </summary>
        public const string ChessQueen = "\uf445";

        /// <summary>
        /// fa-chess-queen-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-queen-alt
        /// </summary>
        public const string ChessQueenAlt = "\uf446";

        /// <summary>
        /// fa-chess-rook unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chess-rook
        /// </summary>
        public const string ChessRook = "\uf447";

        /// <summary>
        /// fa-chess-rook-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chess-rook-alt
        /// </summary>
        public const string ChessRookAlt = "\uf448";

        /// <summary>
        /// fa-chevron-circle-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-circle-down
        /// </summary>
        public const string ChevronCircleDown = "\uf13a";

        /// <summary>
        /// fa-chevron-circle-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-circle-left
        /// </summary>
        public const string ChevronCircleLeft = "\uf137";

        /// <summary>
        /// fa-chevron-circle-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-circle-right
        /// </summary>
        public const string ChevronCircleRight = "\uf138";

        /// <summary>
        /// fa-chevron-circle-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-circle-up
        /// </summary>
        public const string ChevronCircleUp = "\uf139";

        /// <summary>
        /// fa-chevron-double-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-double-down
        /// </summary>
        public const string ChevronDoubleDown = "\uf322";

        /// <summary>
        /// fa-chevron-double-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-double-left
        /// </summary>
        public const string ChevronDoubleLeft = "\uf323";

        /// <summary>
        /// fa-chevron-double-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-double-right
        /// </summary>
        public const string ChevronDoubleRight = "\uf324";

        /// <summary>
        /// fa-chevron-double-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-double-up
        /// </summary>
        public const string ChevronDoubleUp = "\uf325";

        /// <summary>
        /// fa-chevron-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-down
        /// </summary>
        public const string ChevronDown = "\uf078";

        /// <summary>
        /// fa-chevron-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-left
        /// </summary>
        public const string ChevronLeft = "\uf053";

        /// <summary>
        /// fa-chevron-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-right
        /// </summary>
        public const string ChevronRight = "\uf054";

        /// <summary>
        /// fa-chevron-square-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-square-down
        /// </summary>
        public const string ChevronSquareDown = "\uf329";

        /// <summary>
        /// fa-chevron-square-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-square-left
        /// </summary>
        public const string ChevronSquareLeft = "\uf32a";

        /// <summary>
        /// fa-chevron-square-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-square-right
        /// </summary>
        public const string ChevronSquareRight = "\uf32b";

        /// <summary>
        /// fa-chevron-square-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-square-up
        /// </summary>
        public const string ChevronSquareUp = "\uf32c";

        /// <summary>
        /// fa-chevron-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/chevron-up
        /// </summary>
        public const string ChevronUp = "\uf077";

        /// <summary>
        /// fa-child unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/child
        /// </summary>
        public const string Child = "\uf1ae";

        /// <summary>
        /// fa-chrome unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/chrome
        /// </summary>
        public const string Chrome = "\uf268";

        /// <summary>
        /// fa-church unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/church
        /// </summary>
        public const string Church = "\uf51d";

        /// <summary>
        /// fa-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/circle
        /// </summary>
        public const string Circle = "\uf111";

        /// <summary>
        /// fa-circle-notch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/circle-notch
        /// </summary>
        public const string CircleNotch = "\uf1ce";

        /// <summary>
        /// fa-city unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/city
        /// </summary>
        public const string City = "\uf64f";

        /// <summary>
        /// fa-claw-marks unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/claw-marks
        /// </summary>
        public const string ClawMarks = "\uf6c2";

        /// <summary>
        /// fa-clipboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/clipboard
        /// </summary>
        public const string Clipboard = "\uf328";

        /// <summary>
        /// fa-clipboard-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/clipboard-check
        /// </summary>
        public const string ClipboardCheck = "\uf46c";

        /// <summary>
        /// fa-clipboard-list unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/clipboard-list
        /// </summary>
        public const string ClipboardList = "\uf46d";

        /// <summary>
        /// fa-clipboard-list-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/clipboard-list-check
        /// </summary>
        public const string ClipboardListCheck = "\uf737";

        /// <summary>
        /// fa-clipboard-prescription unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/clipboard-prescription
        /// </summary>
        public const string ClipboardPrescription = "\uf5e8";

        /// <summary>
        /// fa-clock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/clock
        /// </summary>
        public const string Clock = "\uf017";

        /// <summary>
        /// fa-clone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/clone
        /// </summary>
        public const string Clone = "\uf24d";

        /// <summary>
        /// fa-closed-captioning unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/closed-captioning
        /// </summary>
        public const string ClosedCaptioning = "\uf20a";

        /// <summary>
        /// fa-cloud unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud
        /// </summary>
        public const string Cloud = "\uf0c2";

        /// <summary>
        /// fa-cloud-download unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-download
        /// </summary>
        public const string CloudDownload = "\uf0ed";

        /// <summary>
        /// fa-cloud-download-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-download-alt
        /// </summary>
        public const string CloudDownloadAlt = "\uf381";

        /// <summary>
        /// fa-cloud-drizzle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-drizzle
        /// </summary>
        public const string CloudDrizzle = "\uf738";

        /// <summary>
        /// fa-cloud-hail unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-hail
        /// </summary>
        public const string CloudHail = "\uf739";

        /// <summary>
        /// fa-cloud-hail-mixed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-hail-mixed
        /// </summary>
        public const string CloudHailMixed = "\uf73a";

        /// <summary>
        /// fa-cloud-meatball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-meatball
        /// </summary>
        public const string CloudMeatball = "\uf73b";

        /// <summary>
        /// fa-cloud-moon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-moon
        /// </summary>
        public const string CloudMoon = "\uf6c3";

        /// <summary>
        /// fa-cloud-moon-rain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-moon-rain
        /// </summary>
        public const string CloudMoonRain = "\uf73c";

        /// <summary>
        /// fa-cloud-rain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-rain
        /// </summary>
        public const string CloudRain = "\uf73d";

        /// <summary>
        /// fa-cloud-rainbow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-rainbow
        /// </summary>
        public const string CloudRainbow = "\uf73e";

        /// <summary>
        /// fa-cloud-showers unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-showers
        /// </summary>
        public const string CloudShowers = "\uf73f";

        /// <summary>
        /// fa-cloud-showers-heavy unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-showers-heavy
        /// </summary>
        public const string CloudShowersHeavy = "\uf740";

        /// <summary>
        /// fa-cloud-sleet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-sleet
        /// </summary>
        public const string CloudSleet = "\uf741";

        /// <summary>
        /// fa-cloud-snow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-snow
        /// </summary>
        public const string CloudSnow = "\uf742";

        /// <summary>
        /// fa-cloud-sun unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-sun
        /// </summary>
        public const string CloudSun = "\uf6c4";

        /// <summary>
        /// fa-cloud-sun-rain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-sun-rain
        /// </summary>
        public const string CloudSunRain = "\uf743";

        /// <summary>
        /// fa-cloud-upload unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-upload
        /// </summary>
        public const string CloudUpload = "\uf0ee";

        /// <summary>
        /// fa-cloud-upload-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cloud-upload-alt
        /// </summary>
        public const string CloudUploadAlt = "\uf382";

        /// <summary>
        /// fa-clouds unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/clouds
        /// </summary>
        public const string Clouds = "\uf744";

        /// <summary>
        /// fa-clouds-moon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/clouds-moon
        /// </summary>
        public const string CloudsMoon = "\uf745";

        /// <summary>
        /// fa-clouds-sun unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/clouds-sun
        /// </summary>
        public const string CloudsSun = "\uf746";

        /// <summary>
        /// fa-cloudscale unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cloudscale
        /// </summary>
        public const string Cloudscale = "\uf383";

        /// <summary>
        /// fa-cloudsmith unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cloudsmith
        /// </summary>
        public const string Cloudsmith = "\uf384";

        /// <summary>
        /// fa-cloudversify unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cloudversify
        /// </summary>
        public const string Cloudversify = "\uf385";

        /// <summary>
        /// fa-club unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/club
        /// </summary>
        public const string Club = "\uf327";

        /// <summary>
        /// fa-cocktail unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cocktail
        /// </summary>
        public const string Cocktail = "\uf561";

        /// <summary>
        /// fa-code unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/code
        /// </summary>
        public const string Code = "\uf121";

        /// <summary>
        /// fa-code-branch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/code-branch
        /// </summary>
        public const string CodeBranch = "\uf126";

        /// <summary>
        /// fa-code-commit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/code-commit
        /// </summary>
        public const string CodeCommit = "\uf386";

        /// <summary>
        /// fa-code-merge unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/code-merge
        /// </summary>
        public const string CodeMerge = "\uf387";

        /// <summary>
        /// fa-codepen unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/codepen
        /// </summary>
        public const string Codepen = "\uf1cb";

        /// <summary>
        /// fa-codiepie unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/codiepie
        /// </summary>
        public const string Codiepie = "\uf284";

        /// <summary>
        /// fa-coffee unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/coffee
        /// </summary>
        public const string Coffee = "\uf0f4";

        /// <summary>
        /// fa-coffee-togo unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/coffee-togo
        /// </summary>
        public const string CoffeeTogo = "\uf6c5";

        /// <summary>
        /// fa-coffin unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/coffin
        /// </summary>
        public const string Coffin = "\uf6c6";

        /// <summary>
        /// fa-cog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cog
        /// </summary>
        public const string Cog = "\uf013";

        /// <summary>
        /// fa-cogs unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cogs
        /// </summary>
        public const string Cogs = "\uf085";

        /// <summary>
        /// fa-coins unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/coins
        /// </summary>
        public const string Coins = "\uf51e";

        /// <summary>
        /// fa-columns unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/columns
        /// </summary>
        public const string Columns = "\uf0db";

        /// <summary>
        /// fa-comment unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comment
        /// </summary>
        public const string Comment = "\uf075";

        /// <summary>
        /// fa-comment-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt
        /// </summary>
        public const string CommentAlt = "\uf27a";

        /// <summary>
        /// fa-comment-alt-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-check
        /// </summary>
        public const string CommentAltCheck = "\uf4a2";

        /// <summary>
        /// fa-comment-alt-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-dollar
        /// </summary>
        public const string CommentAltDollar = "\uf650";

        /// <summary>
        /// fa-comment-alt-dots unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-dots
        /// </summary>
        public const string CommentAltDots = "\uf4a3";

        /// <summary>
        /// fa-comment-alt-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-edit
        /// </summary>
        public const string CommentAltEdit = "\uf4a4";

        /// <summary>
        /// fa-comment-alt-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-exclamation
        /// </summary>
        public const string CommentAltExclamation = "\uf4a5";

        /// <summary>
        /// fa-comment-alt-lines unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-lines
        /// </summary>
        public const string CommentAltLines = "\uf4a6";

        /// <summary>
        /// fa-comment-alt-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-minus
        /// </summary>
        public const string CommentAltMinus = "\uf4a7";

        /// <summary>
        /// fa-comment-alt-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-plus
        /// </summary>
        public const string CommentAltPlus = "\uf4a8";

        /// <summary>
        /// fa-comment-alt-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-slash
        /// </summary>
        public const string CommentAltSlash = "\uf4a9";

        /// <summary>
        /// fa-comment-alt-smile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-smile
        /// </summary>
        public const string CommentAltSmile = "\uf4aa";

        /// <summary>
        /// fa-comment-alt-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-alt-times
        /// </summary>
        public const string CommentAltTimes = "\uf4ab";

        /// <summary>
        /// fa-comment-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-check
        /// </summary>
        public const string CommentCheck = "\uf4ac";

        /// <summary>
        /// fa-comment-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comment-dollar
        /// </summary>
        public const string CommentDollar = "\uf651";

        /// <summary>
        /// fa-comment-dots unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comment-dots
        /// </summary>
        public const string CommentDots = "\uf4ad";

        /// <summary>
        /// fa-comment-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-edit
        /// </summary>
        public const string CommentEdit = "\uf4ae";

        /// <summary>
        /// fa-comment-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-exclamation
        /// </summary>
        public const string CommentExclamation = "\uf4af";

        /// <summary>
        /// fa-comment-lines unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-lines
        /// </summary>
        public const string CommentLines = "\uf4b0";

        /// <summary>
        /// fa-comment-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-minus
        /// </summary>
        public const string CommentMinus = "\uf4b1";

        /// <summary>
        /// fa-comment-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-plus
        /// </summary>
        public const string CommentPlus = "\uf4b2";

        /// <summary>
        /// fa-comment-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comment-slash
        /// </summary>
        public const string CommentSlash = "\uf4b3";

        /// <summary>
        /// fa-comment-smile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-smile
        /// </summary>
        public const string CommentSmile = "\uf4b4";

        /// <summary>
        /// fa-comment-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comment-times
        /// </summary>
        public const string CommentTimes = "\uf4b5";

        /// <summary>
        /// fa-comments unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comments
        /// </summary>
        public const string Comments = "\uf086";

        /// <summary>
        /// fa-comments-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comments-alt
        /// </summary>
        public const string CommentsAlt = "\uf4b6";

        /// <summary>
        /// fa-comments-alt-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/comments-alt-dollar
        /// </summary>
        public const string CommentsAltDollar = "\uf652";

        /// <summary>
        /// fa-comments-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/comments-dollar
        /// </summary>
        public const string CommentsDollar = "\uf653";

        /// <summary>
        /// fa-compact-disc unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/compact-disc
        /// </summary>
        public const string CompactDisc = "\uf51f";

        /// <summary>
        /// fa-compass unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/compass
        /// </summary>
        public const string Compass = "\uf14e";

        /// <summary>
        /// fa-compass-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/compass-slash
        /// </summary>
        public const string CompassSlash = "\uf5e9";

        /// <summary>
        /// fa-compress unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/compress
        /// </summary>
        public const string Compress = "\uf066";

        /// <summary>
        /// fa-compress-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/compress-alt
        /// </summary>
        public const string CompressAlt = "\uf422";

        /// <summary>
        /// fa-compress-wide unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/compress-wide
        /// </summary>
        public const string CompressWide = "\uf326";

        /// <summary>
        /// fa-concierge-bell unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/concierge-bell
        /// </summary>
        public const string ConciergeBell = "\uf562";

        /// <summary>
        /// fa-connectdevelop unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/connectdevelop
        /// </summary>
        public const string Connectdevelop = "\uf20e";

        /// <summary>
        /// fa-container-storage unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/container-storage
        /// </summary>
        public const string ContainerStorage = "\uf4b7";

        /// <summary>
        /// fa-contao unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/contao
        /// </summary>
        public const string Contao = "\uf26d";

        /// <summary>
        /// fa-conveyor-belt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/conveyor-belt
        /// </summary>
        public const string ConveyorBelt = "\uf46e";

        /// <summary>
        /// fa-conveyor-belt-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/conveyor-belt-alt
        /// </summary>
        public const string ConveyorBeltAlt = "\uf46f";

        /// <summary>
        /// fa-cookie unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cookie
        /// </summary>
        public const string Cookie = "\uf563";

        /// <summary>
        /// fa-cookie-bite unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cookie-bite
        /// </summary>
        public const string CookieBite = "\uf564";

        /// <summary>
        /// fa-copy unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/copy
        /// </summary>
        public const string Copy = "\uf0c5";

        /// <summary>
        /// fa-copyright unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/copyright
        /// </summary>
        public const string Copyright = "\uf1f9";

        /// <summary>
        /// fa-corn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/corn
        /// </summary>
        public const string Corn = "\uf6c7";

        /// <summary>
        /// fa-couch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/couch
        /// </summary>
        public const string Couch = "\uf4b8";

        /// <summary>
        /// fa-cow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cow
        /// </summary>
        public const string Cow = "\uf6c8";

        /// <summary>
        /// fa-cpanel unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cpanel
        /// </summary>
        public const string Cpanel = "\uf388";

        /// <summary>
        /// fa-creative-commons unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons
        /// </summary>
        public const string CreativeCommons = "\uf25e";

        /// <summary>
        /// fa-creative-commons-by unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-by
        /// </summary>
        public const string CreativeCommonsBy = "\uf4e7";

        /// <summary>
        /// fa-creative-commons-nc unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-nc
        /// </summary>
        public const string CreativeCommonsNc = "\uf4e8";

        /// <summary>
        /// fa-creative-commons-nc-eu unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-nc-eu
        /// </summary>
        public const string CreativeCommonsNcEu = "\uf4e9";

        /// <summary>
        /// fa-creative-commons-nc-jp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-nc-jp
        /// </summary>
        public const string CreativeCommonsNcJp = "\uf4ea";

        /// <summary>
        /// fa-creative-commons-nd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-nd
        /// </summary>
        public const string CreativeCommonsNd = "\uf4eb";

        /// <summary>
        /// fa-creative-commons-pd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-pd
        /// </summary>
        public const string CreativeCommonsPd = "\uf4ec";

        /// <summary>
        /// fa-creative-commons-pd-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-pd-alt
        /// </summary>
        public const string CreativeCommonsPdAlt = "\uf4ed";

        /// <summary>
        /// fa-creative-commons-remix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-remix
        /// </summary>
        public const string CreativeCommonsRemix = "\uf4ee";

        /// <summary>
        /// fa-creative-commons-sa unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-sa
        /// </summary>
        public const string CreativeCommonsSa = "\uf4ef";

        /// <summary>
        /// fa-creative-commons-sampling unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-sampling
        /// </summary>
        public const string CreativeCommonsSampling = "\uf4f0";

        /// <summary>
        /// fa-creative-commons-sampling-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-sampling-plus
        /// </summary>
        public const string CreativeCommonsSamplingPlus = "\uf4f1";

        /// <summary>
        /// fa-creative-commons-share unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-share
        /// </summary>
        public const string CreativeCommonsShare = "\uf4f2";

        /// <summary>
        /// fa-creative-commons-zero unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/creative-commons-zero
        /// </summary>
        public const string CreativeCommonsZero = "\uf4f3";

        /// <summary>
        /// fa-credit-card unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/credit-card
        /// </summary>
        public const string CreditCard = "\uf09d";

        /// <summary>
        /// fa-credit-card-blank unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/credit-card-blank
        /// </summary>
        public const string CreditCardBlank = "\uf389";

        /// <summary>
        /// fa-credit-card-front unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/credit-card-front
        /// </summary>
        public const string CreditCardFront = "\uf38a";

        /// <summary>
        /// fa-cricket unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/cricket
        /// </summary>
        public const string Cricket = "\uf449";

        /// <summary>
        /// fa-critical-role unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/critical-role
        /// </summary>
        public const string CriticalRole = "\uf6c9";

        /// <summary>
        /// fa-crop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/crop
        /// </summary>
        public const string Crop = "\uf125";

        /// <summary>
        /// fa-crop-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/crop-alt
        /// </summary>
        public const string CropAlt = "\uf565";

        /// <summary>
        /// fa-cross unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cross
        /// </summary>
        public const string Cross = "\uf654";

        /// <summary>
        /// fa-crosshairs unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/crosshairs
        /// </summary>
        public const string Crosshairs = "\uf05b";

        /// <summary>
        /// fa-crow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/crow
        /// </summary>
        public const string Crow = "\uf520";

        /// <summary>
        /// fa-crown unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/crown
        /// </summary>
        public const string Crown = "\uf521";

        /// <summary>
        /// fa-css3 unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/css3
        /// </summary>
        public const string Css3 = "\uf13c";

        /// <summary>
        /// fa-css3-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/css3-alt
        /// </summary>
        public const string Css3Alt = "\uf38b";

        /// <summary>
        /// fa-cube unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cube
        /// </summary>
        public const string Cube = "\uf1b2";

        /// <summary>
        /// fa-cubes unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cubes
        /// </summary>
        public const string Cubes = "\uf1b3";

        /// <summary>
        /// fa-curling unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/curling
        /// </summary>
        public const string Curling = "\uf44a";

        /// <summary>
        /// fa-cut unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/cut
        /// </summary>
        public const string Cut = "\uf0c4";

        /// <summary>
        /// fa-cuttlefish unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/cuttlefish
        /// </summary>
        public const string Cuttlefish = "\uf38c";

        /// <summary>
        /// fa-d-and-d unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/d-and-d
        /// </summary>
        public const string DAndD = "\uf38d";

        /// <summary>
        /// fa-d-and-d-beyond unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/d-and-d-beyond
        /// </summary>
        public const string DAndDBeyond = "\uf6ca";

        /// <summary>
        /// fa-dagger unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dagger
        /// </summary>
        public const string Dagger = "\uf6cb";

        /// <summary>
        /// fa-dashcube unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dashcube
        /// </summary>
        public const string Dashcube = "\uf210";

        /// <summary>
        /// fa-database unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/database
        /// </summary>
        public const string Database = "\uf1c0";

        /// <summary>
        /// fa-deaf unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/deaf
        /// </summary>
        public const string Deaf = "\uf2a4";

        /// <summary>
        /// fa-delicious unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/delicious
        /// </summary>
        public const string Delicious = "\uf1a5";

        /// <summary>
        /// fa-democrat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/democrat
        /// </summary>
        public const string Democrat = "\uf747";

        /// <summary>
        /// fa-deploydog unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/deploydog
        /// </summary>
        public const string Deploydog = "\uf38e";

        /// <summary>
        /// fa-deskpro unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/deskpro
        /// </summary>
        public const string Deskpro = "\uf38f";

        /// <summary>
        /// fa-desktop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/desktop
        /// </summary>
        public const string Desktop = "\uf108";

        /// <summary>
        /// fa-desktop-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/desktop-alt
        /// </summary>
        public const string DesktopAlt = "\uf390";

        /// <summary>
        /// fa-dev unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dev
        /// </summary>
        public const string Dev = "\uf6cc";

        /// <summary>
        /// fa-deviantart unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/deviantart
        /// </summary>
        public const string Deviantart = "\uf1bd";

        /// <summary>
        /// fa-dewpoint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dewpoint
        /// </summary>
        public const string Dewpoint = "\uf748";

        /// <summary>
        /// fa-dharmachakra unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dharmachakra
        /// </summary>
        public const string Dharmachakra = "\uf655";

        /// <summary>
        /// fa-diagnoses unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/diagnoses
        /// </summary>
        public const string Diagnoses = "\uf470";

        /// <summary>
        /// fa-diamond unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/diamond
        /// </summary>
        public const string Diamond = "\uf219";

        /// <summary>
        /// fa-dice unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice
        /// </summary>
        public const string Dice = "\uf522";

        /// <summary>
        /// fa-dice-d10 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d10
        /// </summary>
        public const string DiceD10 = "\uf6cd";

        /// <summary>
        /// fa-dice-d12 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d12
        /// </summary>
        public const string DiceD12 = "\uf6ce";

        /// <summary>
        /// fa-dice-d20 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d20
        /// </summary>
        public const string DiceD20 = "\uf6cf";

        /// <summary>
        /// fa-dice-d4 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d4
        /// </summary>
        public const string DiceD4 = "\uf6d0";

        /// <summary>
        /// fa-dice-d6 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d6
        /// </summary>
        public const string DiceD6 = "\uf6d1";

        /// <summary>
        /// fa-dice-d8 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dice-d8
        /// </summary>
        public const string DiceD8 = "\uf6d2";

        /// <summary>
        /// fa-dice-five unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-five
        /// </summary>
        public const string DiceFive = "\uf523";

        /// <summary>
        /// fa-dice-four unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-four
        /// </summary>
        public const string DiceFour = "\uf524";

        /// <summary>
        /// fa-dice-one unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-one
        /// </summary>
        public const string DiceOne = "\uf525";

        /// <summary>
        /// fa-dice-six unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-six
        /// </summary>
        public const string DiceSix = "\uf526";

        /// <summary>
        /// fa-dice-three unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-three
        /// </summary>
        public const string DiceThree = "\uf527";

        /// <summary>
        /// fa-dice-two unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dice-two
        /// </summary>
        public const string DiceTwo = "\uf528";

        /// <summary>
        /// fa-digg unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/digg
        /// </summary>
        public const string Digg = "\uf1a6";

        /// <summary>
        /// fa-digital-ocean unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/digital-ocean
        /// </summary>
        public const string DigitalOcean = "\uf391";

        /// <summary>
        /// fa-digital-tachograph unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/digital-tachograph
        /// </summary>
        public const string DigitalTachograph = "\uf566";

        /// <summary>
        /// fa-diploma unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/diploma
        /// </summary>
        public const string Diploma = "\uf5ea";

        /// <summary>
        /// fa-directions unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/directions
        /// </summary>
        public const string Directions = "\uf5eb";

        /// <summary>
        /// fa-discord unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/discord
        /// </summary>
        public const string Discord = "\uf392";

        /// <summary>
        /// fa-discourse unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/discourse
        /// </summary>
        public const string Discourse = "\uf393";

        /// <summary>
        /// fa-divide unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/divide
        /// </summary>
        public const string Divide = "\uf529";

        /// <summary>
        /// fa-dizzy unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dizzy
        /// </summary>
        public const string Dizzy = "\uf567";

        /// <summary>
        /// fa-dna unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dna
        /// </summary>
        public const string Dna = "\uf471";

        /// <summary>
        /// fa-do-not-enter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/do-not-enter
        /// </summary>
        public const string DoNotEnter = "\uf5ec";

        /// <summary>
        /// fa-dochub unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dochub
        /// </summary>
        public const string Dochub = "\uf394";

        /// <summary>
        /// fa-docker unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/docker
        /// </summary>
        public const string Docker = "\uf395";

        /// <summary>
        /// fa-dog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dog
        /// </summary>
        public const string Dog = "\uf6d3";

        /// <summary>
        /// fa-dog-leashed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dog-leashed
        /// </summary>
        public const string DogLeashed = "\uf6d4";

        /// <summary>
        /// fa-dollar-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dollar-sign
        /// </summary>
        public const string DollarSign = "\uf155";

        /// <summary>
        /// fa-dolly unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dolly
        /// </summary>
        public const string Dolly = "\uf472";

        /// <summary>
        /// fa-dolly-empty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dolly-empty
        /// </summary>
        public const string DollyEmpty = "\uf473";

        /// <summary>
        /// fa-dolly-flatbed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dolly-flatbed
        /// </summary>
        public const string DollyFlatbed = "\uf474";

        /// <summary>
        /// fa-dolly-flatbed-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dolly-flatbed-alt
        /// </summary>
        public const string DollyFlatbedAlt = "\uf475";

        /// <summary>
        /// fa-dolly-flatbed-empty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/dolly-flatbed-empty
        /// </summary>
        public const string DollyFlatbedEmpty = "\uf476";

        /// <summary>
        /// fa-donate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/donate
        /// </summary>
        public const string Donate = "\uf4b9";

        /// <summary>
        /// fa-door-closed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/door-closed
        /// </summary>
        public const string DoorClosed = "\uf52a";

        /// <summary>
        /// fa-door-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/door-open
        /// </summary>
        public const string DoorOpen = "\uf52b";

        /// <summary>
        /// fa-dot-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dot-circle
        /// </summary>
        public const string DotCircle = "\uf192";

        /// <summary>
        /// fa-dove unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dove
        /// </summary>
        public const string Dove = "\uf4ba";

        /// <summary>
        /// fa-download unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/download
        /// </summary>
        public const string Download = "\uf019";

        /// <summary>
        /// fa-draft2digital unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/draft2digital
        /// </summary>
        public const string Draft2digital = "\uf396";

        /// <summary>
        /// fa-drafting-compass unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/drafting-compass
        /// </summary>
        public const string DraftingCompass = "\uf568";

        /// <summary>
        /// fa-dragon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dragon
        /// </summary>
        public const string Dragon = "\uf6d5";

        /// <summary>
        /// fa-draw-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/draw-circle
        /// </summary>
        public const string DrawCircle = "\uf5ed";

        /// <summary>
        /// fa-draw-polygon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/draw-polygon
        /// </summary>
        public const string DrawPolygon = "\uf5ee";

        /// <summary>
        /// fa-draw-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/draw-square
        /// </summary>
        public const string DrawSquare = "\uf5ef";

        /// <summary>
        /// fa-dribbble unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dribbble
        /// </summary>
        public const string Dribbble = "\uf17d";

        /// <summary>
        /// fa-dribbble-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dribbble-square
        /// </summary>
        public const string DribbbleSquare = "\uf397";

        /// <summary>
        /// fa-dropbox unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dropbox
        /// </summary>
        public const string Dropbox = "\uf16b";

        /// <summary>
        /// fa-drum unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/drum
        /// </summary>
        public const string Drum = "\uf569";

        /// <summary>
        /// fa-drum-steelpan unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/drum-steelpan
        /// </summary>
        public const string DrumSteelpan = "\uf56a";

        /// <summary>
        /// fa-drumstick unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/drumstick
        /// </summary>
        public const string Drumstick = "\uf6d6";

        /// <summary>
        /// fa-drumstick-bite unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/drumstick-bite
        /// </summary>
        public const string DrumstickBite = "\uf6d7";

        /// <summary>
        /// fa-drupal unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/drupal
        /// </summary>
        public const string Drupal = "\uf1a9";

        /// <summary>
        /// fa-duck unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/duck
        /// </summary>
        public const string Duck = "\uf6d8";

        /// <summary>
        /// fa-dumbbell unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dumbbell
        /// </summary>
        public const string Dumbbell = "\uf44b";

        /// <summary>
        /// fa-dungeon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/dungeon
        /// </summary>
        public const string Dungeon = "\uf6d9";

        /// <summary>
        /// fa-dyalog unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/dyalog
        /// </summary>
        public const string Dyalog = "\uf399";

        /// <summary>
        /// fa-ear unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ear
        /// </summary>
        public const string Ear = "\uf5f0";

        /// <summary>
        /// fa-earlybirds unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/earlybirds
        /// </summary>
        public const string Earlybirds = "\uf39a";

        /// <summary>
        /// fa-ebay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ebay
        /// </summary>
        public const string Ebay = "\uf4f4";

        /// <summary>
        /// fa-eclipse unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/eclipse
        /// </summary>
        public const string Eclipse = "\uf749";

        /// <summary>
        /// fa-eclipse-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/eclipse-alt
        /// </summary>
        public const string EclipseAlt = "\uf74a";

        /// <summary>
        /// fa-edge unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/edge
        /// </summary>
        public const string Edge = "\uf282";

        /// <summary>
        /// fa-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/edit
        /// </summary>
        public const string Edit = "\uf044";

        /// <summary>
        /// fa-eject unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/eject
        /// </summary>
        public const string Eject = "\uf052";

        /// <summary>
        /// fa-elementor unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/elementor
        /// </summary>
        public const string Elementor = "\uf430";

        /// <summary>
        /// fa-elephant unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/elephant
        /// </summary>
        public const string Elephant = "\uf6da";

        /// <summary>
        /// fa-ellipsis-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ellipsis-h
        /// </summary>
        public const string EllipsisH = "\uf141";

        /// <summary>
        /// fa-ellipsis-h-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ellipsis-h-alt
        /// </summary>
        public const string EllipsisHAlt = "\uf39b";

        /// <summary>
        /// fa-ellipsis-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ellipsis-v
        /// </summary>
        public const string EllipsisV = "\uf142";

        /// <summary>
        /// fa-ellipsis-v-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ellipsis-v-alt
        /// </summary>
        public const string EllipsisVAlt = "\uf39c";

        /// <summary>
        /// fa-ello unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ello
        /// </summary>
        public const string Ello = "\uf5f1";

        /// <summary>
        /// fa-ember unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ember
        /// </summary>
        public const string Ember = "\uf423";

        /// <summary>
        /// fa-empire unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/empire
        /// </summary>
        public const string Empire = "\uf1d1";

        /// <summary>
        /// fa-empty-set unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/empty-set
        /// </summary>
        public const string EmptySet = "\uf656";

        /// <summary>
        /// fa-engine-warning unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/engine-warning
        /// </summary>
        public const string EngineWarning = "\uf5f2";

        /// <summary>
        /// fa-envelope unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/envelope
        /// </summary>
        public const string Envelope = "\uf0e0";

        /// <summary>
        /// fa-envelope-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/envelope-open
        /// </summary>
        public const string EnvelopeOpen = "\uf2b6";

        /// <summary>
        /// fa-envelope-open-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/envelope-open-dollar
        /// </summary>
        public const string EnvelopeOpenDollar = "\uf657";

        /// <summary>
        /// fa-envelope-open-text unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/envelope-open-text
        /// </summary>
        public const string EnvelopeOpenText = "\uf658";

        /// <summary>
        /// fa-envelope-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/envelope-square
        /// </summary>
        public const string EnvelopeSquare = "\uf199";

        /// <summary>
        /// fa-envira unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/envira
        /// </summary>
        public const string Envira = "\uf299";

        /// <summary>
        /// fa-equals unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/equals
        /// </summary>
        public const string Equals = "\uf52c";

        /// <summary>
        /// fa-eraser unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/eraser
        /// </summary>
        public const string Eraser = "\uf12d";

        /// <summary>
        /// fa-erlang unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/erlang
        /// </summary>
        public const string Erlang = "\uf39d";

        /// <summary>
        /// fa-ethereum unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ethereum
        /// </summary>
        public const string Ethereum = "\uf42e";

        /// <summary>
        /// fa-etsy unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/etsy
        /// </summary>
        public const string Etsy = "\uf2d7";

        /// <summary>
        /// fa-euro-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/euro-sign
        /// </summary>
        public const string EuroSign = "\uf153";

        /// <summary>
        /// fa-exchange unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/exchange
        /// </summary>
        public const string Exchange = "\uf0ec";

        /// <summary>
        /// fa-exchange-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/exchange-alt
        /// </summary>
        public const string ExchangeAlt = "\uf362";

        /// <summary>
        /// fa-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/exclamation
        /// </summary>
        public const string Exclamation = "\uf12a";

        /// <summary>
        /// fa-exclamation-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/exclamation-circle
        /// </summary>
        public const string ExclamationCircle = "\uf06a";

        /// <summary>
        /// fa-exclamation-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/exclamation-square
        /// </summary>
        public const string ExclamationSquare = "\uf321";

        /// <summary>
        /// fa-exclamation-triangle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/exclamation-triangle
        /// </summary>
        public const string ExclamationTriangle = "\uf071";

        /// <summary>
        /// fa-expand unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/expand
        /// </summary>
        public const string Expand = "\uf065";

        /// <summary>
        /// fa-expand-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/expand-alt
        /// </summary>
        public const string ExpandAlt = "\uf424";

        /// <summary>
        /// fa-expand-arrows unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/expand-arrows
        /// </summary>
        public const string ExpandArrows = "\uf31d";

        /// <summary>
        /// fa-expand-arrows-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/expand-arrows-alt
        /// </summary>
        public const string ExpandArrowsAlt = "\uf31e";

        /// <summary>
        /// fa-expand-wide unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/expand-wide
        /// </summary>
        public const string ExpandWide = "\uf320";

        /// <summary>
        /// fa-expeditedssl unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/expeditedssl
        /// </summary>
        public const string Expeditedssl = "\uf23e";

        /// <summary>
        /// fa-external-link unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/external-link
        /// </summary>
        public const string ExternalLink = "\uf08e";

        /// <summary>
        /// fa-external-link-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/external-link-alt
        /// </summary>
        public const string ExternalLinkAlt = "\uf35d";

        /// <summary>
        /// fa-external-link-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/external-link-square
        /// </summary>
        public const string ExternalLinkSquare = "\uf14c";

        /// <summary>
        /// fa-external-link-square-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/external-link-square-alt
        /// </summary>
        public const string ExternalLinkSquareAlt = "\uf360";

        /// <summary>
        /// fa-eye unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/eye
        /// </summary>
        public const string Eye = "\uf06e";

        /// <summary>
        /// fa-eye-dropper unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/eye-dropper
        /// </summary>
        public const string EyeDropper = "\uf1fb";

        /// <summary>
        /// fa-eye-evil unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/eye-evil
        /// </summary>
        public const string EyeEvil = "\uf6db";

        /// <summary>
        /// fa-eye-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/eye-slash
        /// </summary>
        public const string EyeSlash = "\uf070";

        /// <summary>
        /// fa-facebook unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/facebook
        /// </summary>
        public const string Facebook = "\uf09a";

        /// <summary>
        /// fa-facebook-f unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/facebook-f
        /// </summary>
        public const string FacebookF = "\uf39e";

        /// <summary>
        /// fa-facebook-messenger unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/facebook-messenger
        /// </summary>
        public const string FacebookMessenger = "\uf39f";

        /// <summary>
        /// fa-facebook-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/facebook-square
        /// </summary>
        public const string FacebookSquare = "\uf082";

        /// <summary>
        /// fa-fantasy-flight-games unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fantasy-flight-games
        /// </summary>
        public const string FantasyFlightGames = "\uf6dc";

        /// <summary>
        /// fa-fast-backward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fast-backward
        /// </summary>
        public const string FastBackward = "\uf049";

        /// <summary>
        /// fa-fast-forward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fast-forward
        /// </summary>
        public const string FastForward = "\uf050";

        /// <summary>
        /// fa-fax unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fax
        /// </summary>
        public const string Fax = "\uf1ac";

        /// <summary>
        /// fa-feather unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/feather
        /// </summary>
        public const string Feather = "\uf52d";

        /// <summary>
        /// fa-feather-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/feather-alt
        /// </summary>
        public const string FeatherAlt = "\uf56b";

        /// <summary>
        /// fa-female unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/female
        /// </summary>
        public const string Female = "\uf182";

        /// <summary>
        /// fa-field-hockey unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/field-hockey
        /// </summary>
        public const string FieldHockey = "\uf44c";

        /// <summary>
        /// fa-fighter-jet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fighter-jet
        /// </summary>
        public const string FighterJet = "\uf0fb";

        /// <summary>
        /// fa-file unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file
        /// </summary>
        public const string File = "\uf15b";

        /// <summary>
        /// fa-file-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-alt
        /// </summary>
        public const string FileAlt = "\uf15c";

        /// <summary>
        /// fa-file-archive unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-archive
        /// </summary>
        public const string FileArchive = "\uf1c6";

        /// <summary>
        /// fa-file-audio unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-audio
        /// </summary>
        public const string FileAudio = "\uf1c7";

        /// <summary>
        /// fa-file-certificate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-certificate
        /// </summary>
        public const string FileCertificate = "\uf5f3";

        /// <summary>
        /// fa-file-chart-line unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-chart-line
        /// </summary>
        public const string FileChartLine = "\uf659";

        /// <summary>
        /// fa-file-chart-pie unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-chart-pie
        /// </summary>
        public const string FileChartPie = "\uf65a";

        /// <summary>
        /// fa-file-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-check
        /// </summary>
        public const string FileCheck = "\uf316";

        /// <summary>
        /// fa-file-code unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-code
        /// </summary>
        public const string FileCode = "\uf1c9";

        /// <summary>
        /// fa-file-contract unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-contract
        /// </summary>
        public const string FileContract = "\uf56c";

        /// <summary>
        /// fa-file-csv unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-csv
        /// </summary>
        public const string FileCsv = "\uf6dd";

        /// <summary>
        /// fa-file-download unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-download
        /// </summary>
        public const string FileDownload = "\uf56d";

        /// <summary>
        /// fa-file-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-edit
        /// </summary>
        public const string FileEdit = "\uf31c";

        /// <summary>
        /// fa-file-excel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-excel
        /// </summary>
        public const string FileExcel = "\uf1c3";

        /// <summary>
        /// fa-file-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-exclamation
        /// </summary>
        public const string FileExclamation = "\uf31a";

        /// <summary>
        /// fa-file-export unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-export
        /// </summary>
        public const string FileExport = "\uf56e";

        /// <summary>
        /// fa-file-image unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-image
        /// </summary>
        public const string FileImage = "\uf1c5";

        /// <summary>
        /// fa-file-import unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-import
        /// </summary>
        public const string FileImport = "\uf56f";

        /// <summary>
        /// fa-file-invoice unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-invoice
        /// </summary>
        public const string FileInvoice = "\uf570";

        /// <summary>
        /// fa-file-invoice-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-invoice-dollar
        /// </summary>
        public const string FileInvoiceDollar = "\uf571";

        /// <summary>
        /// fa-file-medical unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-medical
        /// </summary>
        public const string FileMedical = "\uf477";

        /// <summary>
        /// fa-file-medical-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-medical-alt
        /// </summary>
        public const string FileMedicalAlt = "\uf478";

        /// <summary>
        /// fa-file-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-minus
        /// </summary>
        public const string FileMinus = "\uf318";

        /// <summary>
        /// fa-file-pdf unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-pdf
        /// </summary>
        public const string FilePdf = "\uf1c1";

        /// <summary>
        /// fa-file-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-plus
        /// </summary>
        public const string FilePlus = "\uf319";

        /// <summary>
        /// fa-file-powerpoint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-powerpoint
        /// </summary>
        public const string FilePowerpoint = "\uf1c4";

        /// <summary>
        /// fa-file-prescription unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-prescription
        /// </summary>
        public const string FilePrescription = "\uf572";

        /// <summary>
        /// fa-file-signature unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-signature
        /// </summary>
        public const string FileSignature = "\uf573";

        /// <summary>
        /// fa-file-spreadsheet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-spreadsheet
        /// </summary>
        public const string FileSpreadsheet = "\uf65b";

        /// <summary>
        /// fa-file-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-times
        /// </summary>
        public const string FileTimes = "\uf317";

        /// <summary>
        /// fa-file-upload unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-upload
        /// </summary>
        public const string FileUpload = "\uf574";

        /// <summary>
        /// fa-file-user unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/file-user
        /// </summary>
        public const string FileUser = "\uf65c";

        /// <summary>
        /// fa-file-video unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-video
        /// </summary>
        public const string FileVideo = "\uf1c8";

        /// <summary>
        /// fa-file-word unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/file-word
        /// </summary>
        public const string FileWord = "\uf1c2";

        /// <summary>
        /// fa-fill unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fill
        /// </summary>
        public const string Fill = "\uf575";

        /// <summary>
        /// fa-fill-drip unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fill-drip
        /// </summary>
        public const string FillDrip = "\uf576";

        /// <summary>
        /// fa-film unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/film
        /// </summary>
        public const string Film = "\uf008";

        /// <summary>
        /// fa-film-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/film-alt
        /// </summary>
        public const string FilmAlt = "\uf3a0";

        /// <summary>
        /// fa-filter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/filter
        /// </summary>
        public const string Filter = "\uf0b0";

        /// <summary>
        /// fa-fingerprint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fingerprint
        /// </summary>
        public const string Fingerprint = "\uf577";

        /// <summary>
        /// fa-fire unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fire
        /// </summary>
        public const string Fire = "\uf06d";

        /// <summary>
        /// fa-fire-extinguisher unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fire-extinguisher
        /// </summary>
        public const string FireExtinguisher = "\uf134";

        /// <summary>
        /// fa-fire-smoke unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/fire-smoke
        /// </summary>
        public const string FireSmoke = "\uf74b";

        /// <summary>
        /// fa-firefox unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/firefox
        /// </summary>
        public const string Firefox = "\uf269";

        /// <summary>
        /// fa-first-aid unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/first-aid
        /// </summary>
        public const string FirstAid = "\uf479";

        /// <summary>
        /// fa-first-order unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/first-order
        /// </summary>
        public const string FirstOrder = "\uf2b0";

        /// <summary>
        /// fa-first-order-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/first-order-alt
        /// </summary>
        public const string FirstOrderAlt = "\uf50a";

        /// <summary>
        /// fa-firstdraft unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/firstdraft
        /// </summary>
        public const string Firstdraft = "\uf3a1";

        /// <summary>
        /// fa-fish unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fish
        /// </summary>
        public const string Fish = "\uf578";

        /// <summary>
        /// fa-fist-raised unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/fist-raised
        /// </summary>
        public const string FistRaised = "\uf6de";

        /// <summary>
        /// fa-flag unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/flag
        /// </summary>
        public const string Flag = "\uf024";

        /// <summary>
        /// fa-flag-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/flag-alt
        /// </summary>
        public const string FlagAlt = "\uf74c";

        /// <summary>
        /// fa-flag-checkered unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/flag-checkered
        /// </summary>
        public const string FlagCheckered = "\uf11e";

        /// <summary>
        /// fa-flag-usa unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/flag-usa
        /// </summary>
        public const string FlagUsa = "\uf74d";

        /// <summary>
        /// fa-flame unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/flame
        /// </summary>
        public const string Flame = "\uf6df";

        /// <summary>
        /// fa-flask unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/flask
        /// </summary>
        public const string Flask = "\uf0c3";

        /// <summary>
        /// fa-flask-poison unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/flask-poison
        /// </summary>
        public const string FlaskPoison = "\uf6e0";

        /// <summary>
        /// fa-flask-potion unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/flask-potion
        /// </summary>
        public const string FlaskPotion = "\uf6e1";

        /// <summary>
        /// fa-flickr unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/flickr
        /// </summary>
        public const string Flickr = "\uf16e";

        /// <summary>
        /// fa-flipboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/flipboard
        /// </summary>
        public const string Flipboard = "\uf44d";

        /// <summary>
        /// fa-flushed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/flushed
        /// </summary>
        public const string Flushed = "\uf579";

        /// <summary>
        /// fa-fly unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fly
        /// </summary>
        public const string Fly = "\uf417";

        /// <summary>
        /// fa-fog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/fog
        /// </summary>
        public const string Fog = "\uf74e";

        /// <summary>
        /// fa-folder unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/folder
        /// </summary>
        public const string Folder = "\uf07b";

        /// <summary>
        /// fa-folder-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/folder-minus
        /// </summary>
        public const string FolderMinus = "\uf65d";

        /// <summary>
        /// fa-folder-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/folder-open
        /// </summary>
        public const string FolderOpen = "\uf07c";

        /// <summary>
        /// fa-folder-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/folder-plus
        /// </summary>
        public const string FolderPlus = "\uf65e";

        /// <summary>
        /// fa-folder-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/folder-times
        /// </summary>
        public const string FolderTimes = "\uf65f";

        /// <summary>
        /// fa-folders unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/folders
        /// </summary>
        public const string Folders = "\uf660";

        /// <summary>
        /// fa-font unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/font
        /// </summary>
        public const string Font = "\uf031";

        /// <summary>
        /// fa-font-awesome unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/font-awesome
        /// </summary>
        public const string FontAwesome = "\uf2b4";

        /// <summary>
        /// fa-font-awesome-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/font-awesome-alt
        /// </summary>
        public const string FontAwesomeAlt = "\uf35c";

        /// <summary>
        /// fa-font-awesome-flag unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/font-awesome-flag
        /// </summary>
        public const string FontAwesomeFlag = "\uf425";

        /// <summary>
        /// fa-fonticons unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fonticons
        /// </summary>
        public const string Fonticons = "\uf280";

        /// <summary>
        /// fa-fonticons-fi unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fonticons-fi
        /// </summary>
        public const string FonticonsFi = "\uf3a2";

        /// <summary>
        /// fa-football-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/football-ball
        /// </summary>
        public const string FootballBall = "\uf44e";

        /// <summary>
        /// fa-football-helmet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/football-helmet
        /// </summary>
        public const string FootballHelmet = "\uf44f";

        /// <summary>
        /// fa-forklift unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/forklift
        /// </summary>
        public const string Forklift = "\uf47a";

        /// <summary>
        /// fa-fort-awesome unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fort-awesome
        /// </summary>
        public const string FortAwesome = "\uf286";

        /// <summary>
        /// fa-fort-awesome-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fort-awesome-alt
        /// </summary>
        public const string FortAwesomeAlt = "\uf3a3";

        /// <summary>
        /// fa-forumbee unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/forumbee
        /// </summary>
        public const string Forumbee = "\uf211";

        /// <summary>
        /// fa-forward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/forward
        /// </summary>
        public const string Forward = "\uf04e";

        /// <summary>
        /// fa-foursquare unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/foursquare
        /// </summary>
        public const string Foursquare = "\uf180";

        /// <summary>
        /// fa-fragile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/fragile
        /// </summary>
        public const string Fragile = "\uf4bb";

        /// <summary>
        /// fa-free-code-camp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/free-code-camp
        /// </summary>
        public const string FreeCodeCamp = "\uf2c5";

        /// <summary>
        /// fa-freebsd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/freebsd
        /// </summary>
        public const string Freebsd = "\uf3a4";

        /// <summary>
        /// fa-frog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/frog
        /// </summary>
        public const string Frog = "\uf52e";

        /// <summary>
        /// fa-frown unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/frown
        /// </summary>
        public const string Frown = "\uf119";

        /// <summary>
        /// fa-frown-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/frown-open
        /// </summary>
        public const string FrownOpen = "\uf57a";

        /// <summary>
        /// fa-fulcrum unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/fulcrum
        /// </summary>
        public const string Fulcrum = "\uf50b";

        /// <summary>
        /// fa-function unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/function
        /// </summary>
        public const string Function = "\uf661";

        /// <summary>
        /// fa-funnel-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/funnel-dollar
        /// </summary>
        public const string FunnelDollar = "\uf662";

        /// <summary>
        /// fa-futbol unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/futbol
        /// </summary>
        public const string Futbol = "\uf1e3";

        /// <summary>
        /// fa-galactic-republic unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/galactic-republic
        /// </summary>
        public const string GalacticRepublic = "\uf50c";

        /// <summary>
        /// fa-galactic-senate unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/galactic-senate
        /// </summary>
        public const string GalacticSenate = "\uf50d";

        /// <summary>
        /// fa-gamepad unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gamepad
        /// </summary>
        public const string Gamepad = "\uf11b";

        /// <summary>
        /// fa-gas-pump unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gas-pump
        /// </summary>
        public const string GasPump = "\uf52f";

        /// <summary>
        /// fa-gas-pump-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/gas-pump-slash
        /// </summary>
        public const string GasPumpSlash = "\uf5f4";

        /// <summary>
        /// fa-gavel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gavel
        /// </summary>
        public const string Gavel = "\uf0e3";

        /// <summary>
        /// fa-gem unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gem
        /// </summary>
        public const string Gem = "\uf3a5";

        /// <summary>
        /// fa-genderless unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/genderless
        /// </summary>
        public const string Genderless = "\uf22d";

        /// <summary>
        /// fa-get-pocket unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/get-pocket
        /// </summary>
        public const string GetPocket = "\uf265";

        /// <summary>
        /// fa-gg unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gg
        /// </summary>
        public const string Gg = "\uf260";

        /// <summary>
        /// fa-gg-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gg-circle
        /// </summary>
        public const string GgCircle = "\uf261";

        /// <summary>
        /// fa-ghost unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ghost
        /// </summary>
        public const string Ghost = "\uf6e2";

        /// <summary>
        /// fa-gift unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gift
        /// </summary>
        public const string Gift = "\uf06b";

        /// <summary>
        /// fa-gift-card unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/gift-card
        /// </summary>
        public const string GiftCard = "\uf663";

        /// <summary>
        /// fa-git unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/git
        /// </summary>
        public const string Git = "\uf1d3";

        /// <summary>
        /// fa-git-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/git-square
        /// </summary>
        public const string GitSquare = "\uf1d2";

        /// <summary>
        /// fa-github unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/github
        /// </summary>
        public const string Github = "\uf09b";

        /// <summary>
        /// fa-github-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/github-alt
        /// </summary>
        public const string GithubAlt = "\uf113";

        /// <summary>
        /// fa-github-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/github-square
        /// </summary>
        public const string GithubSquare = "\uf092";

        /// <summary>
        /// fa-gitkraken unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gitkraken
        /// </summary>
        public const string Gitkraken = "\uf3a6";

        /// <summary>
        /// fa-gitlab unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gitlab
        /// </summary>
        public const string Gitlab = "\uf296";

        /// <summary>
        /// fa-gitter unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gitter
        /// </summary>
        public const string Gitter = "\uf426";

        /// <summary>
        /// fa-glass-martini unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/glass-martini
        /// </summary>
        public const string GlassMartini = "\uf000";

        /// <summary>
        /// fa-glass-martini-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/glass-martini-alt
        /// </summary>
        public const string GlassMartiniAlt = "\uf57b";

        /// <summary>
        /// fa-glasses unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/glasses
        /// </summary>
        public const string Glasses = "\uf530";

        /// <summary>
        /// fa-glasses-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/glasses-alt
        /// </summary>
        public const string GlassesAlt = "\uf5f5";

        /// <summary>
        /// fa-glide unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/glide
        /// </summary>
        public const string Glide = "\uf2a5";

        /// <summary>
        /// fa-glide-g unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/glide-g
        /// </summary>
        public const string GlideG = "\uf2a6";

        /// <summary>
        /// fa-globe unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/globe
        /// </summary>
        public const string Globe = "\uf0ac";

        /// <summary>
        /// fa-globe-africa unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/globe-africa
        /// </summary>
        public const string GlobeAfrica = "\uf57c";

        /// <summary>
        /// fa-globe-americas unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/globe-americas
        /// </summary>
        public const string GlobeAmericas = "\uf57d";

        /// <summary>
        /// fa-globe-asia unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/globe-asia
        /// </summary>
        public const string GlobeAsia = "\uf57e";

        /// <summary>
        /// fa-globe-stand unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/globe-stand
        /// </summary>
        public const string GlobeStand = "\uf5f6";

        /// <summary>
        /// fa-gofore unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gofore
        /// </summary>
        public const string Gofore = "\uf3a7";

        /// <summary>
        /// fa-golf-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/golf-ball
        /// </summary>
        public const string GolfBall = "\uf450";

        /// <summary>
        /// fa-golf-club unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/golf-club
        /// </summary>
        public const string GolfClub = "\uf451";

        /// <summary>
        /// fa-goodreads unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/goodreads
        /// </summary>
        public const string Goodreads = "\uf3a8";

        /// <summary>
        /// fa-goodreads-g unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/goodreads-g
        /// </summary>
        public const string GoodreadsG = "\uf3a9";

        /// <summary>
        /// fa-google unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google
        /// </summary>
        public const string Google = "\uf1a0";

        /// <summary>
        /// fa-google-drive unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-drive
        /// </summary>
        public const string GoogleDrive = "\uf3aa";

        /// <summary>
        /// fa-google-play unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-play
        /// </summary>
        public const string GooglePlay = "\uf3ab";

        /// <summary>
        /// fa-google-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-plus
        /// </summary>
        public const string GooglePlus = "\uf2b3";

        /// <summary>
        /// fa-google-plus-g unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-plus-g
        /// </summary>
        public const string GooglePlusG = "\uf0d5";

        /// <summary>
        /// fa-google-plus-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-plus-square
        /// </summary>
        public const string GooglePlusSquare = "\uf0d4";

        /// <summary>
        /// fa-google-wallet unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/google-wallet
        /// </summary>
        public const string GoogleWallet = "\uf1ee";

        /// <summary>
        /// fa-gopuram unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/gopuram
        /// </summary>
        public const string Gopuram = "\uf664";

        /// <summary>
        /// fa-graduation-cap unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/graduation-cap
        /// </summary>
        public const string GraduationCap = "\uf19d";

        /// <summary>
        /// fa-gratipay unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gratipay
        /// </summary>
        public const string Gratipay = "\uf184";

        /// <summary>
        /// fa-grav unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/grav
        /// </summary>
        public const string Grav = "\uf2d6";

        /// <summary>
        /// fa-greater-than unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/greater-than
        /// </summary>
        public const string GreaterThan = "\uf531";

        /// <summary>
        /// fa-greater-than-equal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/greater-than-equal
        /// </summary>
        public const string GreaterThanEqual = "\uf532";

        /// <summary>
        /// fa-grimace unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grimace
        /// </summary>
        public const string Grimace = "\uf57f";

        /// <summary>
        /// fa-grin unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin
        /// </summary>
        public const string Grin = "\uf580";

        /// <summary>
        /// fa-grin-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-alt
        /// </summary>
        public const string GrinAlt = "\uf581";

        /// <summary>
        /// fa-grin-beam unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-beam
        /// </summary>
        public const string GrinBeam = "\uf582";

        /// <summary>
        /// fa-grin-beam-sweat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-beam-sweat
        /// </summary>
        public const string GrinBeamSweat = "\uf583";

        /// <summary>
        /// fa-grin-hearts unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-hearts
        /// </summary>
        public const string GrinHearts = "\uf584";

        /// <summary>
        /// fa-grin-squint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-squint
        /// </summary>
        public const string GrinSquint = "\uf585";

        /// <summary>
        /// fa-grin-squint-tears unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-squint-tears
        /// </summary>
        public const string GrinSquintTears = "\uf586";

        /// <summary>
        /// fa-grin-stars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-stars
        /// </summary>
        public const string GrinStars = "\uf587";

        /// <summary>
        /// fa-grin-tears unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-tears
        /// </summary>
        public const string GrinTears = "\uf588";

        /// <summary>
        /// fa-grin-tongue unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-tongue
        /// </summary>
        public const string GrinTongue = "\uf589";

        /// <summary>
        /// fa-grin-tongue-squint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-tongue-squint
        /// </summary>
        public const string GrinTongueSquint = "\uf58a";

        /// <summary>
        /// fa-grin-tongue-wink unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-tongue-wink
        /// </summary>
        public const string GrinTongueWink = "\uf58b";

        /// <summary>
        /// fa-grin-wink unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grin-wink
        /// </summary>
        public const string GrinWink = "\uf58c";

        /// <summary>
        /// fa-grip-horizontal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grip-horizontal
        /// </summary>
        public const string GripHorizontal = "\uf58d";

        /// <summary>
        /// fa-grip-vertical unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/grip-vertical
        /// </summary>
        public const string GripVertical = "\uf58e";

        /// <summary>
        /// fa-gripfire unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gripfire
        /// </summary>
        public const string Gripfire = "\uf3ac";

        /// <summary>
        /// fa-grunt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/grunt
        /// </summary>
        public const string Grunt = "\uf3ad";

        /// <summary>
        /// fa-gulp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/gulp
        /// </summary>
        public const string Gulp = "\uf3ae";

        /// <summary>
        /// fa-h-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/h-square
        /// </summary>
        public const string HSquare = "\uf0fd";

        /// <summary>
        /// fa-h1 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/h1
        /// </summary>
        public const string H1 = "\uf313";

        /// <summary>
        /// fa-h2 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/h2
        /// </summary>
        public const string H2 = "\uf314";

        /// <summary>
        /// fa-h3 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/h3
        /// </summary>
        public const string H3 = "\uf315";

        /// <summary>
        /// fa-hacker-news unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hacker-news
        /// </summary>
        public const string HackerNews = "\uf1d4";

        /// <summary>
        /// fa-hacker-news-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hacker-news-square
        /// </summary>
        public const string HackerNewsSquare = "\uf3af";

        /// <summary>
        /// fa-hackerrank unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hackerrank
        /// </summary>
        public const string Hackerrank = "\uf5f7";

        /// <summary>
        /// fa-hammer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hammer
        /// </summary>
        public const string Hammer = "\uf6e3";

        /// <summary>
        /// fa-hammer-war unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hammer-war
        /// </summary>
        public const string HammerWar = "\uf6e4";

        /// <summary>
        /// fa-hamsa unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hamsa
        /// </summary>
        public const string Hamsa = "\uf665";

        /// <summary>
        /// fa-hand-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-heart
        /// </summary>
        public const string HandHeart = "\uf4bc";

        /// <summary>
        /// fa-hand-holding unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding
        /// </summary>
        public const string HandHolding = "\uf4bd";

        /// <summary>
        /// fa-hand-holding-box unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-box
        /// </summary>
        public const string HandHoldingBox = "\uf47b";

        /// <summary>
        /// fa-hand-holding-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-heart
        /// </summary>
        public const string HandHoldingHeart = "\uf4be";

        /// <summary>
        /// fa-hand-holding-magic unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-magic
        /// </summary>
        public const string HandHoldingMagic = "\uf6e5";

        /// <summary>
        /// fa-hand-holding-seedling unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-seedling
        /// </summary>
        public const string HandHoldingSeedling = "\uf4bf";

        /// <summary>
        /// fa-hand-holding-usd unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-usd
        /// </summary>
        public const string HandHoldingUsd = "\uf4c0";

        /// <summary>
        /// fa-hand-holding-water unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-holding-water
        /// </summary>
        public const string HandHoldingWater = "\uf4c1";

        /// <summary>
        /// fa-hand-lizard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-lizard
        /// </summary>
        public const string HandLizard = "\uf258";

        /// <summary>
        /// fa-hand-paper unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-paper
        /// </summary>
        public const string HandPaper = "\uf256";

        /// <summary>
        /// fa-hand-peace unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-peace
        /// </summary>
        public const string HandPeace = "\uf25b";

        /// <summary>
        /// fa-hand-point-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-point-down
        /// </summary>
        public const string HandPointDown = "\uf0a7";

        /// <summary>
        /// fa-hand-point-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-point-left
        /// </summary>
        public const string HandPointLeft = "\uf0a5";

        /// <summary>
        /// fa-hand-point-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-point-right
        /// </summary>
        public const string HandPointRight = "\uf0a4";

        /// <summary>
        /// fa-hand-point-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-point-up
        /// </summary>
        public const string HandPointUp = "\uf0a6";

        /// <summary>
        /// fa-hand-pointer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-pointer
        /// </summary>
        public const string HandPointer = "\uf25a";

        /// <summary>
        /// fa-hand-receiving unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hand-receiving
        /// </summary>
        public const string HandReceiving = "\uf47c";

        /// <summary>
        /// fa-hand-rock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-rock
        /// </summary>
        public const string HandRock = "\uf255";

        /// <summary>
        /// fa-hand-scissors unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-scissors
        /// </summary>
        public const string HandScissors = "\uf257";

        /// <summary>
        /// fa-hand-spock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hand-spock
        /// </summary>
        public const string HandSpock = "\uf259";

        /// <summary>
        /// fa-hands unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hands
        /// </summary>
        public const string Hands = "\uf4c2";

        /// <summary>
        /// fa-hands-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hands-heart
        /// </summary>
        public const string HandsHeart = "\uf4c3";

        /// <summary>
        /// fa-hands-helping unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hands-helping
        /// </summary>
        public const string HandsHelping = "\uf4c4";

        /// <summary>
        /// fa-hands-usd unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hands-usd
        /// </summary>
        public const string HandsUsd = "\uf4c5";

        /// <summary>
        /// fa-handshake unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/handshake
        /// </summary>
        public const string Handshake = "\uf2b5";

        /// <summary>
        /// fa-handshake-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/handshake-alt
        /// </summary>
        public const string HandshakeAlt = "\uf4c6";

        /// <summary>
        /// fa-hanukiah unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hanukiah
        /// </summary>
        public const string Hanukiah = "\uf6e6";

        /// <summary>
        /// fa-hashtag unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hashtag
        /// </summary>
        public const string Hashtag = "\uf292";

        /// <summary>
        /// fa-hat-witch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hat-witch
        /// </summary>
        public const string HatWitch = "\uf6e7";

        /// <summary>
        /// fa-hat-wizard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hat-wizard
        /// </summary>
        public const string HatWizard = "\uf6e8";

        /// <summary>
        /// fa-haykal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/haykal
        /// </summary>
        public const string Haykal = "\uf666";

        /// <summary>
        /// fa-hdd unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hdd
        /// </summary>
        public const string Hdd = "\uf0a0";

        /// <summary>
        /// fa-head-side unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/head-side
        /// </summary>
        public const string HeadSide = "\uf6e9";

        /// <summary>
        /// fa-head-vr unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/head-vr
        /// </summary>
        public const string HeadVr = "\uf6ea";

        /// <summary>
        /// fa-heading unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/heading
        /// </summary>
        public const string Heading = "\uf1dc";

        /// <summary>
        /// fa-headphones unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/headphones
        /// </summary>
        public const string Headphones = "\uf025";

        /// <summary>
        /// fa-headphones-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/headphones-alt
        /// </summary>
        public const string HeadphonesAlt = "\uf58f";

        /// <summary>
        /// fa-headset unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/headset
        /// </summary>
        public const string Headset = "\uf590";

        /// <summary>
        /// fa-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/heart
        /// </summary>
        public const string Heart = "\uf004";

        /// <summary>
        /// fa-heart-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/heart-circle
        /// </summary>
        public const string HeartCircle = "\uf4c7";

        /// <summary>
        /// fa-heart-rate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/heart-rate
        /// </summary>
        public const string HeartRate = "\uf5f8";

        /// <summary>
        /// fa-heart-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/heart-square
        /// </summary>
        public const string HeartSquare = "\uf4c8";

        /// <summary>
        /// fa-heartbeat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/heartbeat
        /// </summary>
        public const string Heartbeat = "\uf21e";

        /// <summary>
        /// fa-helicopter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/helicopter
        /// </summary>
        public const string Helicopter = "\uf533";

        /// <summary>
        /// fa-helmet-battle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/helmet-battle
        /// </summary>
        public const string HelmetBattle = "\uf6eb";

        /// <summary>
        /// fa-hexagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hexagon
        /// </summary>
        public const string Hexagon = "\uf312";

        /// <summary>
        /// fa-highlighter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/highlighter
        /// </summary>
        public const string Highlighter = "\uf591";

        /// <summary>
        /// fa-hiking unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hiking
        /// </summary>
        public const string Hiking = "\uf6ec";

        /// <summary>
        /// fa-hippo unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hippo
        /// </summary>
        public const string Hippo = "\uf6ed";

        /// <summary>
        /// fa-hips unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hips
        /// </summary>
        public const string Hips = "\uf452";

        /// <summary>
        /// fa-hire-a-helper unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hire-a-helper
        /// </summary>
        public const string HireAHelper = "\uf3b0";

        /// <summary>
        /// fa-history unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/history
        /// </summary>
        public const string History = "\uf1da";

        /// <summary>
        /// fa-hockey-mask unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hockey-mask
        /// </summary>
        public const string HockeyMask = "\uf6ee";

        /// <summary>
        /// fa-hockey-puck unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hockey-puck
        /// </summary>
        public const string HockeyPuck = "\uf453";

        /// <summary>
        /// fa-hockey-sticks unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hockey-sticks
        /// </summary>
        public const string HockeySticks = "\uf454";

        /// <summary>
        /// fa-home unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/home
        /// </summary>
        public const string Home = "\uf015";

        /// <summary>
        /// fa-home-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/home-heart
        /// </summary>
        public const string HomeHeart = "\uf4c9";

        /// <summary>
        /// fa-hood-cloak unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hood-cloak
        /// </summary>
        public const string HoodCloak = "\uf6ef";

        /// <summary>
        /// fa-hooli unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hooli
        /// </summary>
        public const string Hooli = "\uf427";

        /// <summary>
        /// fa-hornbill unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hornbill
        /// </summary>
        public const string Hornbill = "\uf592";

        /// <summary>
        /// fa-horse unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/horse
        /// </summary>
        public const string Horse = "\uf6f0";

        /// <summary>
        /// fa-hospital unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hospital
        /// </summary>
        public const string Hospital = "\uf0f8";

        /// <summary>
        /// fa-hospital-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hospital-alt
        /// </summary>
        public const string HospitalAlt = "\uf47d";

        /// <summary>
        /// fa-hospital-symbol unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hospital-symbol
        /// </summary>
        public const string HospitalSymbol = "\uf47e";

        /// <summary>
        /// fa-hot-tub unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hot-tub
        /// </summary>
        public const string HotTub = "\uf593";

        /// <summary>
        /// fa-hotel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hotel
        /// </summary>
        public const string Hotel = "\uf594";

        /// <summary>
        /// fa-hotjar unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hotjar
        /// </summary>
        public const string Hotjar = "\uf3b1";

        /// <summary>
        /// fa-hourglass unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hourglass
        /// </summary>
        public const string Hourglass = "\uf254";

        /// <summary>
        /// fa-hourglass-end unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hourglass-end
        /// </summary>
        public const string HourglassEnd = "\uf253";

        /// <summary>
        /// fa-hourglass-half unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hourglass-half
        /// </summary>
        public const string HourglassHalf = "\uf252";

        /// <summary>
        /// fa-hourglass-start unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hourglass-start
        /// </summary>
        public const string HourglassStart = "\uf251";

        /// <summary>
        /// fa-house-damage unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/house-damage
        /// </summary>
        public const string HouseDamage = "\uf6f1";

        /// <summary>
        /// fa-house-flood unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/house-flood
        /// </summary>
        public const string HouseFlood = "\uf74f";

        /// <summary>
        /// fa-houzz unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/houzz
        /// </summary>
        public const string Houzz = "\uf27c";

        /// <summary>
        /// fa-hryvnia unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/hryvnia
        /// </summary>
        public const string Hryvnia = "\uf6f2";

        /// <summary>
        /// fa-html5 unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/html5
        /// </summary>
        public const string Html5 = "\uf13b";

        /// <summary>
        /// fa-hubspot unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/hubspot
        /// </summary>
        public const string Hubspot = "\uf3b2";

        /// <summary>
        /// fa-humidity unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/humidity
        /// </summary>
        public const string Humidity = "\uf750";

        /// <summary>
        /// fa-hurricane unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/hurricane
        /// </summary>
        public const string Hurricane = "\uf751";

        /// <summary>
        /// fa-i-cursor unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/i-cursor
        /// </summary>
        public const string ICursor = "\uf246";

        /// <summary>
        /// fa-id-badge unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/id-badge
        /// </summary>
        public const string IdBadge = "\uf2c1";

        /// <summary>
        /// fa-id-card unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/id-card
        /// </summary>
        public const string IdCard = "\uf2c2";

        /// <summary>
        /// fa-id-card-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/id-card-alt
        /// </summary>
        public const string IdCardAlt = "\uf47f";

        /// <summary>
        /// fa-image unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/image
        /// </summary>
        public const string Image = "\uf03e";

        /// <summary>
        /// fa-images unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/images
        /// </summary>
        public const string Images = "\uf302";

        /// <summary>
        /// fa-imdb unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/imdb
        /// </summary>
        public const string Imdb = "\uf2d8";

        /// <summary>
        /// fa-inbox unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/inbox
        /// </summary>
        public const string Inbox = "\uf01c";

        /// <summary>
        /// fa-inbox-in unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/inbox-in
        /// </summary>
        public const string InboxIn = "\uf310";

        /// <summary>
        /// fa-inbox-out unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/inbox-out
        /// </summary>
        public const string InboxOut = "\uf311";

        /// <summary>
        /// fa-indent unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/indent
        /// </summary>
        public const string Indent = "\uf03c";

        /// <summary>
        /// fa-industry unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/industry
        /// </summary>
        public const string Industry = "\uf275";

        /// <summary>
        /// fa-industry-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/industry-alt
        /// </summary>
        public const string IndustryAlt = "\uf3b3";

        /// <summary>
        /// fa-infinity unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/infinity
        /// </summary>
        public const string Infinity = "\uf534";

        /// <summary>
        /// fa-info unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/info
        /// </summary>
        public const string Info = "\uf129";

        /// <summary>
        /// fa-info-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/info-circle
        /// </summary>
        public const string InfoCircle = "\uf05a";

        /// <summary>
        /// fa-info-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/info-square
        /// </summary>
        public const string InfoSquare = "\uf30f";

        /// <summary>
        /// fa-inhaler unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/inhaler
        /// </summary>
        public const string Inhaler = "\uf5f9";

        /// <summary>
        /// fa-instagram unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/instagram
        /// </summary>
        public const string Instagram = "\uf16d";

        /// <summary>
        /// fa-integral unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/integral
        /// </summary>
        public const string Integral = "\uf667";

        /// <summary>
        /// fa-internet-explorer unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/internet-explorer
        /// </summary>
        public const string InternetExplorer = "\uf26b";

        /// <summary>
        /// fa-intersection unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/intersection
        /// </summary>
        public const string Intersection = "\uf668";

        /// <summary>
        /// fa-inventory unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/inventory
        /// </summary>
        public const string Inventory = "\uf480";

        /// <summary>
        /// fa-ioxhost unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ioxhost
        /// </summary>
        public const string Ioxhost = "\uf208";

        /// <summary>
        /// fa-italic unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/italic
        /// </summary>
        public const string Italic = "\uf033";

        /// <summary>
        /// fa-itunes unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/itunes
        /// </summary>
        public const string Itunes = "\uf3b4";

        /// <summary>
        /// fa-itunes-note unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/itunes-note
        /// </summary>
        public const string ItunesNote = "\uf3b5";

        /// <summary>
        /// fa-jack-o-lantern unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/jack-o-lantern
        /// </summary>
        public const string JackOLantern = "\uf30e";

        /// <summary>
        /// fa-java unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/java
        /// </summary>
        public const string Java = "\uf4e4";

        /// <summary>
        /// fa-jedi unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/jedi
        /// </summary>
        public const string Jedi = "\uf669";

        /// <summary>
        /// fa-jedi-order unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/jedi-order
        /// </summary>
        public const string JediOrder = "\uf50e";

        /// <summary>
        /// fa-jenkins unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/jenkins
        /// </summary>
        public const string Jenkins = "\uf3b6";

        /// <summary>
        /// fa-joget unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/joget
        /// </summary>
        public const string Joget = "\uf3b7";

        /// <summary>
        /// fa-joint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/joint
        /// </summary>
        public const string Joint = "\uf595";

        /// <summary>
        /// fa-joomla unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/joomla
        /// </summary>
        public const string Joomla = "\uf1aa";

        /// <summary>
        /// fa-journal-whills unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/journal-whills
        /// </summary>
        public const string JournalWhills = "\uf66a";

        /// <summary>
        /// fa-js unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/js
        /// </summary>
        public const string Js = "\uf3b8";

        /// <summary>
        /// fa-js-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/js-square
        /// </summary>
        public const string JsSquare = "\uf3b9";

        /// <summary>
        /// fa-jsfiddle unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/jsfiddle
        /// </summary>
        public const string Jsfiddle = "\uf1cc";

        /// <summary>
        /// fa-kaaba unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/kaaba
        /// </summary>
        public const string Kaaba = "\uf66b";

        /// <summary>
        /// fa-kaggle unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/kaggle
        /// </summary>
        public const string Kaggle = "\uf5fa";

        /// <summary>
        /// fa-key unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/key
        /// </summary>
        public const string Key = "\uf084";

        /// <summary>
        /// fa-key-skeleton unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/key-skeleton
        /// </summary>
        public const string KeySkeleton = "\uf6f3";

        /// <summary>
        /// fa-keybase unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/keybase
        /// </summary>
        public const string Keybase = "\uf4f5";

        /// <summary>
        /// fa-keyboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/keyboard
        /// </summary>
        public const string Keyboard = "\uf11c";

        /// <summary>
        /// fa-keycdn unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/keycdn
        /// </summary>
        public const string Keycdn = "\uf3ba";

        /// <summary>
        /// fa-keynote unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/keynote
        /// </summary>
        public const string Keynote = "\uf66c";

        /// <summary>
        /// fa-khanda unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/khanda
        /// </summary>
        public const string Khanda = "\uf66d";

        /// <summary>
        /// fa-kickstarter unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/kickstarter
        /// </summary>
        public const string Kickstarter = "\uf3bb";

        /// <summary>
        /// fa-kickstarter-k unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/kickstarter-k
        /// </summary>
        public const string KickstarterK = "\uf3bc";

        /// <summary>
        /// fa-kidneys unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/kidneys
        /// </summary>
        public const string Kidneys = "\uf5fb";

        /// <summary>
        /// fa-kiss unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/kiss
        /// </summary>
        public const string Kiss = "\uf596";

        /// <summary>
        /// fa-kiss-beam unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/kiss-beam
        /// </summary>
        public const string KissBeam = "\uf597";

        /// <summary>
        /// fa-kiss-wink-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/kiss-wink-heart
        /// </summary>
        public const string KissWinkHeart = "\uf598";

        /// <summary>
        /// fa-kite unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/kite
        /// </summary>
        public const string Kite = "\uf6f4";

        /// <summary>
        /// fa-kiwi-bird unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/kiwi-bird
        /// </summary>
        public const string KiwiBird = "\uf535";

        /// <summary>
        /// fa-knife-kitchen unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/knife-kitchen
        /// </summary>
        public const string KnifeKitchen = "\uf6f5";

        /// <summary>
        /// fa-korvue unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/korvue
        /// </summary>
        public const string Korvue = "\uf42f";

        /// <summary>
        /// fa-lambda unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lambda
        /// </summary>
        public const string Lambda = "\uf66e";

        /// <summary>
        /// fa-lamp unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lamp
        /// </summary>
        public const string Lamp = "\uf4ca";

        /// <summary>
        /// fa-landmark unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/landmark
        /// </summary>
        public const string Landmark = "\uf66f";

        /// <summary>
        /// fa-landmark-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/landmark-alt
        /// </summary>
        public const string LandmarkAlt = "\uf752";

        /// <summary>
        /// fa-language unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/language
        /// </summary>
        public const string Language = "\uf1ab";

        /// <summary>
        /// fa-laptop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laptop
        /// </summary>
        public const string Laptop = "\uf109";

        /// <summary>
        /// fa-laptop-code unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laptop-code
        /// </summary>
        public const string LaptopCode = "\uf5fc";

        /// <summary>
        /// fa-laravel unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/laravel
        /// </summary>
        public const string Laravel = "\uf3bd";

        /// <summary>
        /// fa-lastfm unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/lastfm
        /// </summary>
        public const string Lastfm = "\uf202";

        /// <summary>
        /// fa-lastfm-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/lastfm-square
        /// </summary>
        public const string LastfmSquare = "\uf203";

        /// <summary>
        /// fa-laugh unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laugh
        /// </summary>
        public const string Laugh = "\uf599";

        /// <summary>
        /// fa-laugh-beam unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laugh-beam
        /// </summary>
        public const string LaughBeam = "\uf59a";

        /// <summary>
        /// fa-laugh-squint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laugh-squint
        /// </summary>
        public const string LaughSquint = "\uf59b";

        /// <summary>
        /// fa-laugh-wink unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/laugh-wink
        /// </summary>
        public const string LaughWink = "\uf59c";

        /// <summary>
        /// fa-layer-group unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/layer-group
        /// </summary>
        public const string LayerGroup = "\uf5fd";

        /// <summary>
        /// fa-layer-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/layer-minus
        /// </summary>
        public const string LayerMinus = "\uf5fe";

        /// <summary>
        /// fa-layer-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/layer-plus
        /// </summary>
        public const string LayerPlus = "\uf5ff";

        /// <summary>
        /// fa-leaf unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/leaf
        /// </summary>
        public const string Leaf = "\uf06c";

        /// <summary>
        /// fa-leaf-heart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/leaf-heart
        /// </summary>
        public const string LeafHeart = "\uf4cb";

        /// <summary>
        /// fa-leaf-maple unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/leaf-maple
        /// </summary>
        public const string LeafMaple = "\uf6f6";

        /// <summary>
        /// fa-leaf-oak unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/leaf-oak
        /// </summary>
        public const string LeafOak = "\uf6f7";

        /// <summary>
        /// fa-leanpub unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/leanpub
        /// </summary>
        public const string Leanpub = "\uf212";

        /// <summary>
        /// fa-lemon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/lemon
        /// </summary>
        public const string Lemon = "\uf094";

        /// <summary>
        /// fa-less unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/less
        /// </summary>
        public const string Less = "\uf41d";

        /// <summary>
        /// fa-less-than unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/less-than
        /// </summary>
        public const string LessThan = "\uf536";

        /// <summary>
        /// fa-less-than-equal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/less-than-equal
        /// </summary>
        public const string LessThanEqual = "\uf537";

        /// <summary>
        /// fa-level-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/level-down
        /// </summary>
        public const string LevelDown = "\uf149";

        /// <summary>
        /// fa-level-down-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/level-down-alt
        /// </summary>
        public const string LevelDownAlt = "\uf3be";

        /// <summary>
        /// fa-level-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/level-up
        /// </summary>
        public const string LevelUp = "\uf148";

        /// <summary>
        /// fa-level-up-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/level-up-alt
        /// </summary>
        public const string LevelUpAlt = "\uf3bf";

        /// <summary>
        /// fa-life-ring unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/life-ring
        /// </summary>
        public const string LifeRing = "\uf1cd";

        /// <summary>
        /// fa-lightbulb unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/lightbulb
        /// </summary>
        public const string Lightbulb = "\uf0eb";

        /// <summary>
        /// fa-lightbulb-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lightbulb-dollar
        /// </summary>
        public const string LightbulbDollar = "\uf670";

        /// <summary>
        /// fa-lightbulb-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lightbulb-exclamation
        /// </summary>
        public const string LightbulbExclamation = "\uf671";

        /// <summary>
        /// fa-lightbulb-on unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lightbulb-on
        /// </summary>
        public const string LightbulbOn = "\uf672";

        /// <summary>
        /// fa-lightbulb-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lightbulb-slash
        /// </summary>
        public const string LightbulbSlash = "\uf673";

        /// <summary>
        /// fa-line unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/line
        /// </summary>
        public const string Line = "\uf3c0";

        /// <summary>
        /// fa-link unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/link
        /// </summary>
        public const string Link = "\uf0c1";

        /// <summary>
        /// fa-linkedin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/linkedin
        /// </summary>
        public const string Linkedin = "\uf08c";

        /// <summary>
        /// fa-linkedin-in unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/linkedin-in
        /// </summary>
        public const string LinkedinIn = "\uf0e1";

        /// <summary>
        /// fa-linode unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/linode
        /// </summary>
        public const string Linode = "\uf2b8";

        /// <summary>
        /// fa-linux unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/linux
        /// </summary>
        public const string Linux = "\uf17c";

        /// <summary>
        /// fa-lips unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lips
        /// </summary>
        public const string Lips = "\uf600";

        /// <summary>
        /// fa-lira-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/lira-sign
        /// </summary>
        public const string LiraSign = "\uf195";

        /// <summary>
        /// fa-list unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/list
        /// </summary>
        public const string List = "\uf03a";

        /// <summary>
        /// fa-list-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/list-alt
        /// </summary>
        public const string ListAlt = "\uf022";

        /// <summary>
        /// fa-list-ol unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/list-ol
        /// </summary>
        public const string ListOl = "\uf0cb";

        /// <summary>
        /// fa-list-ul unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/list-ul
        /// </summary>
        public const string ListUl = "\uf0ca";

        /// <summary>
        /// fa-location unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/location
        /// </summary>
        public const string Location = "\uf601";

        /// <summary>
        /// fa-location-arrow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/location-arrow
        /// </summary>
        public const string LocationArrow = "\uf124";

        /// <summary>
        /// fa-location-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/location-circle
        /// </summary>
        public const string LocationCircle = "\uf602";

        /// <summary>
        /// fa-location-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/location-slash
        /// </summary>
        public const string LocationSlash = "\uf603";

        /// <summary>
        /// fa-lock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/lock
        /// </summary>
        public const string Lock = "\uf023";

        /// <summary>
        /// fa-lock-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lock-alt
        /// </summary>
        public const string LockAlt = "\uf30d";

        /// <summary>
        /// fa-lock-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/lock-open
        /// </summary>
        public const string LockOpen = "\uf3c1";

        /// <summary>
        /// fa-lock-open-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lock-open-alt
        /// </summary>
        public const string LockOpenAlt = "\uf3c2";

        /// <summary>
        /// fa-long-arrow-alt-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-alt-down
        /// </summary>
        public const string LongArrowAltDown = "\uf309";

        /// <summary>
        /// fa-long-arrow-alt-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-alt-left
        /// </summary>
        public const string LongArrowAltLeft = "\uf30a";

        /// <summary>
        /// fa-long-arrow-alt-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-alt-right
        /// </summary>
        public const string LongArrowAltRight = "\uf30b";

        /// <summary>
        /// fa-long-arrow-alt-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-alt-up
        /// </summary>
        public const string LongArrowAltUp = "\uf30c";

        /// <summary>
        /// fa-long-arrow-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-down
        /// </summary>
        public const string LongArrowDown = "\uf175";

        /// <summary>
        /// fa-long-arrow-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-left
        /// </summary>
        public const string LongArrowLeft = "\uf177";

        /// <summary>
        /// fa-long-arrow-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-right
        /// </summary>
        public const string LongArrowRight = "\uf178";

        /// <summary>
        /// fa-long-arrow-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/long-arrow-up
        /// </summary>
        public const string LongArrowUp = "\uf176";

        /// <summary>
        /// fa-loveseat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/loveseat
        /// </summary>
        public const string Loveseat = "\uf4cc";

        /// <summary>
        /// fa-low-vision unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/low-vision
        /// </summary>
        public const string LowVision = "\uf2a8";

        /// <summary>
        /// fa-luchador unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/luchador
        /// </summary>
        public const string Luchador = "\uf455";

        /// <summary>
        /// fa-luggage-cart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/luggage-cart
        /// </summary>
        public const string LuggageCart = "\uf59d";

        /// <summary>
        /// fa-lungs unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/lungs
        /// </summary>
        public const string Lungs = "\uf604";

        /// <summary>
        /// fa-lyft unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/lyft
        /// </summary>
        public const string Lyft = "\uf3c3";

        /// <summary>
        /// fa-mace unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mace
        /// </summary>
        public const string Mace = "\uf6f8";

        /// <summary>
        /// fa-magento unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/magento
        /// </summary>
        public const string Magento = "\uf3c4";

        /// <summary>
        /// fa-magic unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/magic
        /// </summary>
        public const string Magic = "\uf0d0";

        /// <summary>
        /// fa-magnet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/magnet
        /// </summary>
        public const string Magnet = "\uf076";

        /// <summary>
        /// fa-mail-bulk unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mail-bulk
        /// </summary>
        public const string MailBulk = "\uf674";

        /// <summary>
        /// fa-mailchimp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mailchimp
        /// </summary>
        public const string Mailchimp = "\uf59e";

        /// <summary>
        /// fa-male unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/male
        /// </summary>
        public const string Male = "\uf183";

        /// <summary>
        /// fa-mandalorian unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mandalorian
        /// </summary>
        public const string Mandalorian = "\uf50f";

        /// <summary>
        /// fa-mandolin unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mandolin
        /// </summary>
        public const string Mandolin = "\uf6f9";

        /// <summary>
        /// fa-map unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map
        /// </summary>
        public const string Map = "\uf279";

        /// <summary>
        /// fa-map-marked unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-marked
        /// </summary>
        public const string MapMarked = "\uf59f";

        /// <summary>
        /// fa-map-marked-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-marked-alt
        /// </summary>
        public const string MapMarkedAlt = "\uf5a0";

        /// <summary>
        /// fa-map-marker unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker
        /// </summary>
        public const string MapMarker = "\uf041";

        /// <summary>
        /// fa-map-marker-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-alt
        /// </summary>
        public const string MapMarkerAlt = "\uf3c5";

        /// <summary>
        /// fa-map-marker-alt-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-alt-slash
        /// </summary>
        public const string MapMarkerAltSlash = "\uf605";

        /// <summary>
        /// fa-map-marker-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-check
        /// </summary>
        public const string MapMarkerCheck = "\uf606";

        /// <summary>
        /// fa-map-marker-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-edit
        /// </summary>
        public const string MapMarkerEdit = "\uf607";

        /// <summary>
        /// fa-map-marker-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-exclamation
        /// </summary>
        public const string MapMarkerExclamation = "\uf608";

        /// <summary>
        /// fa-map-marker-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-minus
        /// </summary>
        public const string MapMarkerMinus = "\uf609";

        /// <summary>
        /// fa-map-marker-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-plus
        /// </summary>
        public const string MapMarkerPlus = "\uf60a";

        /// <summary>
        /// fa-map-marker-question unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-question
        /// </summary>
        public const string MapMarkerQuestion = "\uf60b";

        /// <summary>
        /// fa-map-marker-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-slash
        /// </summary>
        public const string MapMarkerSlash = "\uf60c";

        /// <summary>
        /// fa-map-marker-smile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-smile
        /// </summary>
        public const string MapMarkerSmile = "\uf60d";

        /// <summary>
        /// fa-map-marker-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/map-marker-times
        /// </summary>
        public const string MapMarkerTimes = "\uf60e";

        /// <summary>
        /// fa-map-pin unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-pin
        /// </summary>
        public const string MapPin = "\uf276";

        /// <summary>
        /// fa-map-signs unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/map-signs
        /// </summary>
        public const string MapSigns = "\uf277";

        /// <summary>
        /// fa-markdown unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/markdown
        /// </summary>
        public const string Markdown = "\uf60f";

        /// <summary>
        /// fa-marker unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/marker
        /// </summary>
        public const string Marker = "\uf5a1";

        /// <summary>
        /// fa-mars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mars
        /// </summary>
        public const string Mars = "\uf222";

        /// <summary>
        /// fa-mars-double unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mars-double
        /// </summary>
        public const string MarsDouble = "\uf227";

        /// <summary>
        /// fa-mars-stroke unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mars-stroke
        /// </summary>
        public const string MarsStroke = "\uf229";

        /// <summary>
        /// fa-mars-stroke-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mars-stroke-h
        /// </summary>
        public const string MarsStrokeH = "\uf22b";

        /// <summary>
        /// fa-mars-stroke-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mars-stroke-v
        /// </summary>
        public const string MarsStrokeV = "\uf22a";

        /// <summary>
        /// fa-mask unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mask
        /// </summary>
        public const string Mask = "\uf6fa";

        /// <summary>
        /// fa-mastodon unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mastodon
        /// </summary>
        public const string Mastodon = "\uf4f6";

        /// <summary>
        /// fa-maxcdn unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/maxcdn
        /// </summary>
        public const string Maxcdn = "\uf136";

        /// <summary>
        /// fa-medal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/medal
        /// </summary>
        public const string Medal = "\uf5a2";

        /// <summary>
        /// fa-medapps unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/medapps
        /// </summary>
        public const string Medapps = "\uf3c6";

        /// <summary>
        /// fa-medium unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/medium
        /// </summary>
        public const string Medium = "\uf23a";

        /// <summary>
        /// fa-medium-m unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/medium-m
        /// </summary>
        public const string MediumM = "\uf3c7";

        /// <summary>
        /// fa-medkit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/medkit
        /// </summary>
        public const string Medkit = "\uf0fa";

        /// <summary>
        /// fa-medrt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/medrt
        /// </summary>
        public const string Medrt = "\uf3c8";

        /// <summary>
        /// fa-meetup unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/meetup
        /// </summary>
        public const string Meetup = "\uf2e0";

        /// <summary>
        /// fa-megaphone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/megaphone
        /// </summary>
        public const string Megaphone = "\uf675";

        /// <summary>
        /// fa-megaport unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/megaport
        /// </summary>
        public const string Megaport = "\uf5a3";

        /// <summary>
        /// fa-meh unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/meh
        /// </summary>
        public const string Meh = "\uf11a";

        /// <summary>
        /// fa-meh-blank unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/meh-blank
        /// </summary>
        public const string MehBlank = "\uf5a4";

        /// <summary>
        /// fa-meh-rolling-eyes unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/meh-rolling-eyes
        /// </summary>
        public const string MehRollingEyes = "\uf5a5";

        /// <summary>
        /// fa-memory unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/memory
        /// </summary>
        public const string Memory = "\uf538";

        /// <summary>
        /// fa-menorah unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/menorah
        /// </summary>
        public const string Menorah = "\uf676";

        /// <summary>
        /// fa-mercury unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mercury
        /// </summary>
        public const string Mercury = "\uf223";

        /// <summary>
        /// fa-meteor unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/meteor
        /// </summary>
        public const string Meteor = "\uf753";

        /// <summary>
        /// fa-microchip unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microchip
        /// </summary>
        public const string Microchip = "\uf2db";

        /// <summary>
        /// fa-microphone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microphone
        /// </summary>
        public const string Microphone = "\uf130";

        /// <summary>
        /// fa-microphone-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microphone-alt
        /// </summary>
        public const string MicrophoneAlt = "\uf3c9";

        /// <summary>
        /// fa-microphone-alt-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microphone-alt-slash
        /// </summary>
        public const string MicrophoneAltSlash = "\uf539";

        /// <summary>
        /// fa-microphone-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microphone-slash
        /// </summary>
        public const string MicrophoneSlash = "\uf131";

        /// <summary>
        /// fa-microscope unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/microscope
        /// </summary>
        public const string Microscope = "\uf610";

        /// <summary>
        /// fa-microsoft unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/microsoft
        /// </summary>
        public const string Microsoft = "\uf3ca";

        /// <summary>
        /// fa-mind-share unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mind-share
        /// </summary>
        public const string MindShare = "\uf677";

        /// <summary>
        /// fa-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/minus
        /// </summary>
        public const string Minus = "\uf068";

        /// <summary>
        /// fa-minus-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/minus-circle
        /// </summary>
        public const string MinusCircle = "\uf056";

        /// <summary>
        /// fa-minus-hexagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/minus-hexagon
        /// </summary>
        public const string MinusHexagon = "\uf307";

        /// <summary>
        /// fa-minus-octagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/minus-octagon
        /// </summary>
        public const string MinusOctagon = "\uf308";

        /// <summary>
        /// fa-minus-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/minus-square
        /// </summary>
        public const string MinusSquare = "\uf146";

        /// <summary>
        /// fa-mix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mix
        /// </summary>
        public const string Mix = "\uf3cb";

        /// <summary>
        /// fa-mixcloud unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mixcloud
        /// </summary>
        public const string Mixcloud = "\uf289";

        /// <summary>
        /// fa-mizuni unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/mizuni
        /// </summary>
        public const string Mizuni = "\uf3cc";

        /// <summary>
        /// fa-mobile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mobile
        /// </summary>
        public const string Mobile = "\uf10b";

        /// <summary>
        /// fa-mobile-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mobile-alt
        /// </summary>
        public const string MobileAlt = "\uf3cd";

        /// <summary>
        /// fa-mobile-android unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mobile-android
        /// </summary>
        public const string MobileAndroid = "\uf3ce";

        /// <summary>
        /// fa-mobile-android-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mobile-android-alt
        /// </summary>
        public const string MobileAndroidAlt = "\uf3cf";

        /// <summary>
        /// fa-modx unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/modx
        /// </summary>
        public const string Modx = "\uf285";

        /// <summary>
        /// fa-monero unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/monero
        /// </summary>
        public const string Monero = "\uf3d0";

        /// <summary>
        /// fa-money-bill unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-bill
        /// </summary>
        public const string MoneyBill = "\uf0d6";

        /// <summary>
        /// fa-money-bill-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-bill-alt
        /// </summary>
        public const string MoneyBillAlt = "\uf3d1";

        /// <summary>
        /// fa-money-bill-wave unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-bill-wave
        /// </summary>
        public const string MoneyBillWave = "\uf53a";

        /// <summary>
        /// fa-money-bill-wave-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-bill-wave-alt
        /// </summary>
        public const string MoneyBillWaveAlt = "\uf53b";

        /// <summary>
        /// fa-money-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-check
        /// </summary>
        public const string MoneyCheck = "\uf53c";

        /// <summary>
        /// fa-money-check-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/money-check-alt
        /// </summary>
        public const string MoneyCheckAlt = "\uf53d";

        /// <summary>
        /// fa-monitor-heart-rate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/monitor-heart-rate
        /// </summary>
        public const string MonitorHeartRate = "\uf611";

        /// <summary>
        /// fa-monkey unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/monkey
        /// </summary>
        public const string Monkey = "\uf6fb";

        /// <summary>
        /// fa-monument unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/monument
        /// </summary>
        public const string Monument = "\uf5a6";

        /// <summary>
        /// fa-moon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/moon
        /// </summary>
        public const string Moon = "\uf186";

        /// <summary>
        /// fa-moon-cloud unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/moon-cloud
        /// </summary>
        public const string MoonCloud = "\uf754";

        /// <summary>
        /// fa-moon-stars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/moon-stars
        /// </summary>
        public const string MoonStars = "\uf755";

        /// <summary>
        /// fa-mortar-pestle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mortar-pestle
        /// </summary>
        public const string MortarPestle = "\uf5a7";

        /// <summary>
        /// fa-mosque unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mosque
        /// </summary>
        public const string Mosque = "\uf678";

        /// <summary>
        /// fa-motorcycle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/motorcycle
        /// </summary>
        public const string Motorcycle = "\uf21c";

        /// <summary>
        /// fa-mountain unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mountain
        /// </summary>
        public const string Mountain = "\uf6fc";

        /// <summary>
        /// fa-mountains unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/mountains
        /// </summary>
        public const string Mountains = "\uf6fd";

        /// <summary>
        /// fa-mouse-pointer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/mouse-pointer
        /// </summary>
        public const string MousePointer = "\uf245";

        /// <summary>
        /// fa-music unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/music
        /// </summary>
        public const string Music = "\uf001";

        /// <summary>
        /// fa-napster unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/napster
        /// </summary>
        public const string Napster = "\uf3d2";

        /// <summary>
        /// fa-narwhal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/narwhal
        /// </summary>
        public const string Narwhal = "\uf6fe";

        /// <summary>
        /// fa-neos unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/neos
        /// </summary>
        public const string Neos = "\uf612";

        /// <summary>
        /// fa-network-wired unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/network-wired
        /// </summary>
        public const string NetworkWired = "\uf6ff";

        /// <summary>
        /// fa-neuter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/neuter
        /// </summary>
        public const string Neuter = "\uf22c";

        /// <summary>
        /// fa-newspaper unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/newspaper
        /// </summary>
        public const string Newspaper = "\uf1ea";

        /// <summary>
        /// fa-nimblr unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/nimblr
        /// </summary>
        public const string Nimblr = "\uf5a8";

        /// <summary>
        /// fa-nintendo-switch unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/nintendo-switch
        /// </summary>
        public const string NintendoSwitch = "\uf418";

        /// <summary>
        /// fa-node unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/node
        /// </summary>
        public const string Node = "\uf419";

        /// <summary>
        /// fa-node-js unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/node-js
        /// </summary>
        public const string NodeJs = "\uf3d3";

        /// <summary>
        /// fa-not-equal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/not-equal
        /// </summary>
        public const string NotEqual = "\uf53e";

        /// <summary>
        /// fa-notes-medical unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/notes-medical
        /// </summary>
        public const string NotesMedical = "\uf481";

        /// <summary>
        /// fa-npm unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/npm
        /// </summary>
        public const string Npm = "\uf3d4";

        /// <summary>
        /// fa-ns8 unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ns8
        /// </summary>
        public const string Ns8 = "\uf3d5";

        /// <summary>
        /// fa-nutritionix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/nutritionix
        /// </summary>
        public const string Nutritionix = "\uf3d6";

        /// <summary>
        /// fa-object-group unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/object-group
        /// </summary>
        public const string ObjectGroup = "\uf247";

        /// <summary>
        /// fa-object-ungroup unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/object-ungroup
        /// </summary>
        public const string ObjectUngroup = "\uf248";

        /// <summary>
        /// fa-octagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/octagon
        /// </summary>
        public const string Octagon = "\uf306";

        /// <summary>
        /// fa-odnoklassniki unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/odnoklassniki
        /// </summary>
        public const string Odnoklassniki = "\uf263";

        /// <summary>
        /// fa-odnoklassniki-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/odnoklassniki-square
        /// </summary>
        public const string OdnoklassnikiSquare = "\uf264";

        /// <summary>
        /// fa-oil-can unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/oil-can
        /// </summary>
        public const string OilCan = "\uf613";

        /// <summary>
        /// fa-oil-temp unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/oil-temp
        /// </summary>
        public const string OilTemp = "\uf614";

        /// <summary>
        /// fa-old-republic unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/old-republic
        /// </summary>
        public const string OldRepublic = "\uf510";

        /// <summary>
        /// fa-om unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/om
        /// </summary>
        public const string Om = "\uf679";

        /// <summary>
        /// fa-omega unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/omega
        /// </summary>
        public const string Omega = "\uf67a";

        /// <summary>
        /// fa-opencart unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/opencart
        /// </summary>
        public const string Opencart = "\uf23d";

        /// <summary>
        /// fa-openid unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/openid
        /// </summary>
        public const string Openid = "\uf19b";

        /// <summary>
        /// fa-opera unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/opera
        /// </summary>
        public const string Opera = "\uf26a";

        /// <summary>
        /// fa-optin-monster unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/optin-monster
        /// </summary>
        public const string OptinMonster = "\uf23c";

        /// <summary>
        /// fa-osi unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/osi
        /// </summary>
        public const string Osi = "\uf41a";

        /// <summary>
        /// fa-otter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/otter
        /// </summary>
        public const string Otter = "\uf700";

        /// <summary>
        /// fa-outdent unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/outdent
        /// </summary>
        public const string Outdent = "\uf03b";

        /// <summary>
        /// fa-page4 unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/page4
        /// </summary>
        public const string Page4 = "\uf3d7";

        /// <summary>
        /// fa-pagelines unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pagelines
        /// </summary>
        public const string Pagelines = "\uf18c";

        /// <summary>
        /// fa-paint-brush unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paint-brush
        /// </summary>
        public const string PaintBrush = "\uf1fc";

        /// <summary>
        /// fa-paint-brush-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/paint-brush-alt
        /// </summary>
        public const string PaintBrushAlt = "\uf5a9";

        /// <summary>
        /// fa-paint-roller unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paint-roller
        /// </summary>
        public const string PaintRoller = "\uf5aa";

        /// <summary>
        /// fa-palette unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/palette
        /// </summary>
        public const string Palette = "\uf53f";

        /// <summary>
        /// fa-palfed unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/palfed
        /// </summary>
        public const string Palfed = "\uf3d8";

        /// <summary>
        /// fa-pallet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pallet
        /// </summary>
        public const string Pallet = "\uf482";

        /// <summary>
        /// fa-pallet-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pallet-alt
        /// </summary>
        public const string PalletAlt = "\uf483";

        /// <summary>
        /// fa-paper-plane unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paper-plane
        /// </summary>
        public const string PaperPlane = "\uf1d8";

        /// <summary>
        /// fa-paperclip unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paperclip
        /// </summary>
        public const string Paperclip = "\uf0c6";

        /// <summary>
        /// fa-parachute-box unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/parachute-box
        /// </summary>
        public const string ParachuteBox = "\uf4cd";

        /// <summary>
        /// fa-paragraph unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paragraph
        /// </summary>
        public const string Paragraph = "\uf1dd";

        /// <summary>
        /// fa-parking unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/parking
        /// </summary>
        public const string Parking = "\uf540";

        /// <summary>
        /// fa-parking-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/parking-circle
        /// </summary>
        public const string ParkingCircle = "\uf615";

        /// <summary>
        /// fa-parking-circle-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/parking-circle-slash
        /// </summary>
        public const string ParkingCircleSlash = "\uf616";

        /// <summary>
        /// fa-parking-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/parking-slash
        /// </summary>
        public const string ParkingSlash = "\uf617";

        /// <summary>
        /// fa-passport unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/passport
        /// </summary>
        public const string Passport = "\uf5ab";

        /// <summary>
        /// fa-pastafarianism unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pastafarianism
        /// </summary>
        public const string Pastafarianism = "\uf67b";

        /// <summary>
        /// fa-paste unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paste
        /// </summary>
        public const string Paste = "\uf0ea";

        /// <summary>
        /// fa-patreon unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/patreon
        /// </summary>
        public const string Patreon = "\uf3d9";

        /// <summary>
        /// fa-pause unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pause
        /// </summary>
        public const string Pause = "\uf04c";

        /// <summary>
        /// fa-pause-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pause-circle
        /// </summary>
        public const string PauseCircle = "\uf28b";

        /// <summary>
        /// fa-paw unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/paw
        /// </summary>
        public const string Paw = "\uf1b0";

        /// <summary>
        /// fa-paw-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/paw-alt
        /// </summary>
        public const string PawAlt = "\uf701";

        /// <summary>
        /// fa-paw-claws unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/paw-claws
        /// </summary>
        public const string PawClaws = "\uf702";

        /// <summary>
        /// fa-paypal unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/paypal
        /// </summary>
        public const string Paypal = "\uf1ed";

        /// <summary>
        /// fa-peace unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/peace
        /// </summary>
        public const string Peace = "\uf67c";

        /// <summary>
        /// fa-pegasus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pegasus
        /// </summary>
        public const string Pegasus = "\uf703";

        /// <summary>
        /// fa-pen unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pen
        /// </summary>
        public const string Pen = "\uf304";

        /// <summary>
        /// fa-pen-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pen-alt
        /// </summary>
        public const string PenAlt = "\uf305";

        /// <summary>
        /// fa-pen-fancy unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pen-fancy
        /// </summary>
        public const string PenFancy = "\uf5ac";

        /// <summary>
        /// fa-pen-nib unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pen-nib
        /// </summary>
        public const string PenNib = "\uf5ad";

        /// <summary>
        /// fa-pen-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pen-square
        /// </summary>
        public const string PenSquare = "\uf14b";

        /// <summary>
        /// fa-pencil unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pencil
        /// </summary>
        public const string Pencil = "\uf040";

        /// <summary>
        /// fa-pencil-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pencil-alt
        /// </summary>
        public const string PencilAlt = "\uf303";

        /// <summary>
        /// fa-pencil-paintbrush unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pencil-paintbrush
        /// </summary>
        public const string PencilPaintbrush = "\uf618";

        /// <summary>
        /// fa-pencil-ruler unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pencil-ruler
        /// </summary>
        public const string PencilRuler = "\uf5ae";

        /// <summary>
        /// fa-pennant unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pennant
        /// </summary>
        public const string Pennant = "\uf456";

        /// <summary>
        /// fa-penny-arcade unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/penny-arcade
        /// </summary>
        public const string PennyArcade = "\uf704";

        /// <summary>
        /// fa-people-carry unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/people-carry
        /// </summary>
        public const string PeopleCarry = "\uf4ce";

        /// <summary>
        /// fa-percent unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/percent
        /// </summary>
        public const string Percent = "\uf295";

        /// <summary>
        /// fa-percentage unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/percentage
        /// </summary>
        public const string Percentage = "\uf541";

        /// <summary>
        /// fa-periscope unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/periscope
        /// </summary>
        public const string Periscope = "\uf3da";

        /// <summary>
        /// fa-person-booth unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/person-booth
        /// </summary>
        public const string PersonBooth = "\uf756";

        /// <summary>
        /// fa-person-carry unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/person-carry
        /// </summary>
        public const string PersonCarry = "\uf4cf";

        /// <summary>
        /// fa-person-dolly unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/person-dolly
        /// </summary>
        public const string PersonDolly = "\uf4d0";

        /// <summary>
        /// fa-person-dolly-empty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/person-dolly-empty
        /// </summary>
        public const string PersonDollyEmpty = "\uf4d1";

        /// <summary>
        /// fa-person-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/person-sign
        /// </summary>
        public const string PersonSign = "\uf757";

        /// <summary>
        /// fa-phabricator unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/phabricator
        /// </summary>
        public const string Phabricator = "\uf3db";

        /// <summary>
        /// fa-phoenix-framework unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/phoenix-framework
        /// </summary>
        public const string PhoenixFramework = "\uf3dc";

        /// <summary>
        /// fa-phoenix-squadron unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/phoenix-squadron
        /// </summary>
        public const string PhoenixSquadron = "\uf511";

        /// <summary>
        /// fa-phone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/phone
        /// </summary>
        public const string Phone = "\uf095";

        /// <summary>
        /// fa-phone-office unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/phone-office
        /// </summary>
        public const string PhoneOffice = "\uf67d";

        /// <summary>
        /// fa-phone-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/phone-plus
        /// </summary>
        public const string PhonePlus = "\uf4d2";

        /// <summary>
        /// fa-phone-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/phone-slash
        /// </summary>
        public const string PhoneSlash = "\uf3dd";

        /// <summary>
        /// fa-phone-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/phone-square
        /// </summary>
        public const string PhoneSquare = "\uf098";

        /// <summary>
        /// fa-phone-volume unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/phone-volume
        /// </summary>
        public const string PhoneVolume = "\uf2a0";

        /// <summary>
        /// fa-php unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/php
        /// </summary>
        public const string Php = "\uf457";

        /// <summary>
        /// fa-pi unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pi
        /// </summary>
        public const string Pi = "\uf67e";

        /// <summary>
        /// fa-pie unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pie
        /// </summary>
        public const string Pie = "\uf705";

        /// <summary>
        /// fa-pied-piper unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pied-piper
        /// </summary>
        public const string PiedPiper = "\uf2ae";

        /// <summary>
        /// fa-pied-piper-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pied-piper-alt
        /// </summary>
        public const string PiedPiperAlt = "\uf1a8";

        /// <summary>
        /// fa-pied-piper-hat unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pied-piper-hat
        /// </summary>
        public const string PiedPiperHat = "\uf4e5";

        /// <summary>
        /// fa-pied-piper-pp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pied-piper-pp
        /// </summary>
        public const string PiedPiperPp = "\uf1a7";

        /// <summary>
        /// fa-pig unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pig
        /// </summary>
        public const string Pig = "\uf706";

        /// <summary>
        /// fa-piggy-bank unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/piggy-bank
        /// </summary>
        public const string PiggyBank = "\uf4d3";

        /// <summary>
        /// fa-pills unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pills
        /// </summary>
        public const string Pills = "\uf484";

        /// <summary>
        /// fa-pinterest unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pinterest
        /// </summary>
        public const string Pinterest = "\uf0d2";

        /// <summary>
        /// fa-pinterest-p unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pinterest-p
        /// </summary>
        public const string PinterestP = "\uf231";

        /// <summary>
        /// fa-pinterest-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pinterest-square
        /// </summary>
        public const string PinterestSquare = "\uf0d3";

        /// <summary>
        /// fa-place-of-worship unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/place-of-worship
        /// </summary>
        public const string PlaceOfWorship = "\uf67f";

        /// <summary>
        /// fa-plane unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plane
        /// </summary>
        public const string Plane = "\uf072";

        /// <summary>
        /// fa-plane-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/plane-alt
        /// </summary>
        public const string PlaneAlt = "\uf3de";

        /// <summary>
        /// fa-plane-arrival unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plane-arrival
        /// </summary>
        public const string PlaneArrival = "\uf5af";

        /// <summary>
        /// fa-plane-departure unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plane-departure
        /// </summary>
        public const string PlaneDeparture = "\uf5b0";

        /// <summary>
        /// fa-play unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/play
        /// </summary>
        public const string Play = "\uf04b";

        /// <summary>
        /// fa-play-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/play-circle
        /// </summary>
        public const string PlayCircle = "\uf144";

        /// <summary>
        /// fa-playstation unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/playstation
        /// </summary>
        public const string Playstation = "\uf3df";

        /// <summary>
        /// fa-plug unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plug
        /// </summary>
        public const string Plug = "\uf1e6";

        /// <summary>
        /// fa-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plus
        /// </summary>
        public const string Plus = "\uf067";

        /// <summary>
        /// fa-plus-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plus-circle
        /// </summary>
        public const string PlusCircle = "\uf055";

        /// <summary>
        /// fa-plus-hexagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/plus-hexagon
        /// </summary>
        public const string PlusHexagon = "\uf300";

        /// <summary>
        /// fa-plus-octagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/plus-octagon
        /// </summary>
        public const string PlusOctagon = "\uf301";

        /// <summary>
        /// fa-plus-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/plus-square
        /// </summary>
        public const string PlusSquare = "\uf0fe";

        /// <summary>
        /// fa-podcast unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/podcast
        /// </summary>
        public const string Podcast = "\uf2ce";

        /// <summary>
        /// fa-podium unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/podium
        /// </summary>
        public const string Podium = "\uf680";

        /// <summary>
        /// fa-podium-star unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/podium-star
        /// </summary>
        public const string PodiumStar = "\uf758";

        /// <summary>
        /// fa-poll unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/poll
        /// </summary>
        public const string Poll = "\uf681";

        /// <summary>
        /// fa-poll-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/poll-h
        /// </summary>
        public const string PollH = "\uf682";

        /// <summary>
        /// fa-poll-people unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/poll-people
        /// </summary>
        public const string PollPeople = "\uf759";

        /// <summary>
        /// fa-poo unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/poo
        /// </summary>
        public const string Poo = "\uf2fe";

        /// <summary>
        /// fa-poo-storm unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/poo-storm
        /// </summary>
        public const string PooStorm = "\uf75a";

        /// <summary>
        /// fa-poop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/poop
        /// </summary>
        public const string Poop = "\uf619";

        /// <summary>
        /// fa-portrait unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/portrait
        /// </summary>
        public const string Portrait = "\uf3e0";

        /// <summary>
        /// fa-pound-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pound-sign
        /// </summary>
        public const string PoundSign = "\uf154";

        /// <summary>
        /// fa-power-off unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/power-off
        /// </summary>
        public const string PowerOff = "\uf011";

        /// <summary>
        /// fa-pray unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/pray
        /// </summary>
        public const string Pray = "\uf683";

        /// <summary>
        /// fa-praying-hands unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/praying-hands
        /// </summary>
        public const string PrayingHands = "\uf684";

        /// <summary>
        /// fa-prescription unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/prescription
        /// </summary>
        public const string Prescription = "\uf5b1";

        /// <summary>
        /// fa-prescription-bottle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/prescription-bottle
        /// </summary>
        public const string PrescriptionBottle = "\uf485";

        /// <summary>
        /// fa-prescription-bottle-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/prescription-bottle-alt
        /// </summary>
        public const string PrescriptionBottleAlt = "\uf486";

        /// <summary>
        /// fa-presentation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/presentation
        /// </summary>
        public const string Presentation = "\uf685";

        /// <summary>
        /// fa-print unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/print
        /// </summary>
        public const string Print = "\uf02f";

        /// <summary>
        /// fa-print-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/print-slash
        /// </summary>
        public const string PrintSlash = "\uf686";

        /// <summary>
        /// fa-procedures unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/procedures
        /// </summary>
        public const string Procedures = "\uf487";

        /// <summary>
        /// fa-product-hunt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/product-hunt
        /// </summary>
        public const string ProductHunt = "\uf288";

        /// <summary>
        /// fa-project-diagram unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/project-diagram
        /// </summary>
        public const string ProjectDiagram = "\uf542";

        /// <summary>
        /// fa-pumpkin unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/pumpkin
        /// </summary>
        public const string Pumpkin = "\uf707";

        /// <summary>
        /// fa-pushed unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/pushed
        /// </summary>
        public const string Pushed = "\uf3e1";

        /// <summary>
        /// fa-puzzle-piece unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/puzzle-piece
        /// </summary>
        public const string PuzzlePiece = "\uf12e";

        /// <summary>
        /// fa-python unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/python
        /// </summary>
        public const string Python = "\uf3e2";

        /// <summary>
        /// fa-qq unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/qq
        /// </summary>
        public const string Qq = "\uf1d6";

        /// <summary>
        /// fa-qrcode unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/qrcode
        /// </summary>
        public const string Qrcode = "\uf029";

        /// <summary>
        /// fa-question unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/question
        /// </summary>
        public const string Question = "\uf128";

        /// <summary>
        /// fa-question-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/question-circle
        /// </summary>
        public const string QuestionCircle = "\uf059";

        /// <summary>
        /// fa-question-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/question-square
        /// </summary>
        public const string QuestionSquare = "\uf2fd";

        /// <summary>
        /// fa-quidditch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/quidditch
        /// </summary>
        public const string Quidditch = "\uf458";

        /// <summary>
        /// fa-quinscape unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/quinscape
        /// </summary>
        public const string Quinscape = "\uf459";

        /// <summary>
        /// fa-quora unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/quora
        /// </summary>
        public const string Quora = "\uf2c4";

        /// <summary>
        /// fa-quote-left unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/quote-left
        /// </summary>
        public const string QuoteLeft = "\uf10d";

        /// <summary>
        /// fa-quote-right unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/quote-right
        /// </summary>
        public const string QuoteRight = "\uf10e";

        /// <summary>
        /// fa-quran unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/quran
        /// </summary>
        public const string Quran = "\uf687";

        /// <summary>
        /// fa-r-project unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/r-project
        /// </summary>
        public const string RProject = "\uf4f7";

        /// <summary>
        /// fa-rabbit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/rabbit
        /// </summary>
        public const string Rabbit = "\uf708";

        /// <summary>
        /// fa-rabbit-fast unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/rabbit-fast
        /// </summary>
        public const string RabbitFast = "\uf709";

        /// <summary>
        /// fa-racquet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/racquet
        /// </summary>
        public const string Racquet = "\uf45a";

        /// <summary>
        /// fa-rainbow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/rainbow
        /// </summary>
        public const string Rainbow = "\uf75b";

        /// <summary>
        /// fa-raindrops unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/raindrops
        /// </summary>
        public const string Raindrops = "\uf75c";

        /// <summary>
        /// fa-ram unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ram
        /// </summary>
        public const string Ram = "\uf70a";

        /// <summary>
        /// fa-ramp-loading unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ramp-loading
        /// </summary>
        public const string RampLoading = "\uf4d4";

        /// <summary>
        /// fa-random unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/random
        /// </summary>
        public const string Random = "\uf074";

        /// <summary>
        /// fa-ravelry unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ravelry
        /// </summary>
        public const string Ravelry = "\uf2d9";

        /// <summary>
        /// fa-react unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/react
        /// </summary>
        public const string React = "\uf41b";

        /// <summary>
        /// fa-reacteurope unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/reacteurope
        /// </summary>
        public const string Reacteurope = "\uf75d";

        /// <summary>
        /// fa-readme unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/readme
        /// </summary>
        public const string Readme = "\uf4d5";

        /// <summary>
        /// fa-rebel unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/rebel
        /// </summary>
        public const string Rebel = "\uf1d0";

        /// <summary>
        /// fa-receipt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/receipt
        /// </summary>
        public const string Receipt = "\uf543";

        /// <summary>
        /// fa-rectangle-landscape unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/rectangle-landscape
        /// </summary>
        public const string RectangleLandscape = "\uf2fa";

        /// <summary>
        /// fa-rectangle-portrait unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/rectangle-portrait
        /// </summary>
        public const string RectanglePortrait = "\uf2fb";

        /// <summary>
        /// fa-rectangle-wide unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/rectangle-wide
        /// </summary>
        public const string RectangleWide = "\uf2fc";

        /// <summary>
        /// fa-recycle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/recycle
        /// </summary>
        public const string Recycle = "\uf1b8";

        /// <summary>
        /// fa-red-river unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/red-river
        /// </summary>
        public const string RedRiver = "\uf3e3";

        /// <summary>
        /// fa-reddit unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/reddit
        /// </summary>
        public const string Reddit = "\uf1a1";

        /// <summary>
        /// fa-reddit-alien unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/reddit-alien
        /// </summary>
        public const string RedditAlien = "\uf281";

        /// <summary>
        /// fa-reddit-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/reddit-square
        /// </summary>
        public const string RedditSquare = "\uf1a2";

        /// <summary>
        /// fa-redo unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/redo
        /// </summary>
        public const string Redo = "\uf01e";

        /// <summary>
        /// fa-redo-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/redo-alt
        /// </summary>
        public const string RedoAlt = "\uf2f9";

        /// <summary>
        /// fa-registered unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/registered
        /// </summary>
        public const string Registered = "\uf25d";

        /// <summary>
        /// fa-renren unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/renren
        /// </summary>
        public const string Renren = "\uf18b";

        /// <summary>
        /// fa-repeat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/repeat
        /// </summary>
        public const string Repeat = "\uf363";

        /// <summary>
        /// fa-repeat-1 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/repeat-1
        /// </summary>
        public const string Repeat1 = "\uf365";

        /// <summary>
        /// fa-repeat-1-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/repeat-1-alt
        /// </summary>
        public const string Repeat1Alt = "\uf366";

        /// <summary>
        /// fa-repeat-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/repeat-alt
        /// </summary>
        public const string RepeatAlt = "\uf364";

        /// <summary>
        /// fa-reply unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/reply
        /// </summary>
        public const string Reply = "\uf3e5";

        /// <summary>
        /// fa-reply-all unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/reply-all
        /// </summary>
        public const string ReplyAll = "\uf122";

        /// <summary>
        /// fa-replyd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/replyd
        /// </summary>
        public const string Replyd = "\uf3e6";

        /// <summary>
        /// fa-republican unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/republican
        /// </summary>
        public const string Republican = "\uf75e";

        /// <summary>
        /// fa-researchgate unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/researchgate
        /// </summary>
        public const string Researchgate = "\uf4f8";

        /// <summary>
        /// fa-resolving unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/resolving
        /// </summary>
        public const string Resolving = "\uf3e7";

        /// <summary>
        /// fa-retweet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/retweet
        /// </summary>
        public const string Retweet = "\uf079";

        /// <summary>
        /// fa-retweet-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/retweet-alt
        /// </summary>
        public const string RetweetAlt = "\uf361";

        /// <summary>
        /// fa-rev unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/rev
        /// </summary>
        public const string Rev = "\uf5b2";

        /// <summary>
        /// fa-ribbon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ribbon
        /// </summary>
        public const string Ribbon = "\uf4d6";

        /// <summary>
        /// fa-ring unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ring
        /// </summary>
        public const string Ring = "\uf70b";

        /// <summary>
        /// fa-road unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/road
        /// </summary>
        public const string Road = "\uf018";

        /// <summary>
        /// fa-robot unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/robot
        /// </summary>
        public const string Robot = "\uf544";

        /// <summary>
        /// fa-rocket unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/rocket
        /// </summary>
        public const string Rocket = "\uf135";

        /// <summary>
        /// fa-rocketchat unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/rocketchat
        /// </summary>
        public const string Rocketchat = "\uf3e8";

        /// <summary>
        /// fa-rockrms unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/rockrms
        /// </summary>
        public const string Rockrms = "\uf3e9";

        /// <summary>
        /// fa-route unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/route
        /// </summary>
        public const string Route = "\uf4d7";

        /// <summary>
        /// fa-route-highway unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/route-highway
        /// </summary>
        public const string RouteHighway = "\uf61a";

        /// <summary>
        /// fa-route-interstate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/route-interstate
        /// </summary>
        public const string RouteInterstate = "\uf61b";

        /// <summary>
        /// fa-rss unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/rss
        /// </summary>
        public const string Rss = "\uf09e";

        /// <summary>
        /// fa-rss-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/rss-square
        /// </summary>
        public const string RssSquare = "\uf143";

        /// <summary>
        /// fa-ruble-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ruble-sign
        /// </summary>
        public const string RubleSign = "\uf158";

        /// <summary>
        /// fa-ruler unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ruler
        /// </summary>
        public const string Ruler = "\uf545";

        /// <summary>
        /// fa-ruler-combined unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ruler-combined
        /// </summary>
        public const string RulerCombined = "\uf546";

        /// <summary>
        /// fa-ruler-horizontal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ruler-horizontal
        /// </summary>
        public const string RulerHorizontal = "\uf547";

        /// <summary>
        /// fa-ruler-triangle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ruler-triangle
        /// </summary>
        public const string RulerTriangle = "\uf61c";

        /// <summary>
        /// fa-ruler-vertical unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ruler-vertical
        /// </summary>
        public const string RulerVertical = "\uf548";

        /// <summary>
        /// fa-running unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/running
        /// </summary>
        public const string Running = "\uf70c";

        /// <summary>
        /// fa-rupee-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/rupee-sign
        /// </summary>
        public const string RupeeSign = "\uf156";

        /// <summary>
        /// fa-sad-cry unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sad-cry
        /// </summary>
        public const string SadCry = "\uf5b3";

        /// <summary>
        /// fa-sad-tear unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sad-tear
        /// </summary>
        public const string SadTear = "\uf5b4";

        /// <summary>
        /// fa-safari unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/safari
        /// </summary>
        public const string Safari = "\uf267";

        /// <summary>
        /// fa-sass unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sass
        /// </summary>
        public const string Sass = "\uf41e";

        /// <summary>
        /// fa-save unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/save
        /// </summary>
        public const string Save = "\uf0c7";

        /// <summary>
        /// fa-scalpel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scalpel
        /// </summary>
        public const string Scalpel = "\uf61d";

        /// <summary>
        /// fa-scalpel-path unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scalpel-path
        /// </summary>
        public const string ScalpelPath = "\uf61e";

        /// <summary>
        /// fa-scanner unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scanner
        /// </summary>
        public const string Scanner = "\uf488";

        /// <summary>
        /// fa-scanner-keyboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scanner-keyboard
        /// </summary>
        public const string ScannerKeyboard = "\uf489";

        /// <summary>
        /// fa-scanner-touchscreen unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scanner-touchscreen
        /// </summary>
        public const string ScannerTouchscreen = "\uf48a";

        /// <summary>
        /// fa-scarecrow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scarecrow
        /// </summary>
        public const string Scarecrow = "\uf70d";

        /// <summary>
        /// fa-schlix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/schlix
        /// </summary>
        public const string Schlix = "\uf3ea";

        /// <summary>
        /// fa-school unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/school
        /// </summary>
        public const string School = "\uf549";

        /// <summary>
        /// fa-screwdriver unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/screwdriver
        /// </summary>
        public const string Screwdriver = "\uf54a";

        /// <summary>
        /// fa-scribd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/scribd
        /// </summary>
        public const string Scribd = "\uf28a";

        /// <summary>
        /// fa-scroll unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/scroll
        /// </summary>
        public const string Scroll = "\uf70e";

        /// <summary>
        /// fa-scroll-old unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scroll-old
        /// </summary>
        public const string ScrollOld = "\uf70f";

        /// <summary>
        /// fa-scrubber unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scrubber
        /// </summary>
        public const string Scrubber = "\uf2f8";

        /// <summary>
        /// fa-scythe unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/scythe
        /// </summary>
        public const string Scythe = "\uf710";

        /// <summary>
        /// fa-search unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/search
        /// </summary>
        public const string Search = "\uf002";

        /// <summary>
        /// fa-search-dollar unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/search-dollar
        /// </summary>
        public const string SearchDollar = "\uf688";

        /// <summary>
        /// fa-search-location unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/search-location
        /// </summary>
        public const string SearchLocation = "\uf689";

        /// <summary>
        /// fa-search-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/search-minus
        /// </summary>
        public const string SearchMinus = "\uf010";

        /// <summary>
        /// fa-search-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/search-plus
        /// </summary>
        public const string SearchPlus = "\uf00e";

        /// <summary>
        /// fa-searchengin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/searchengin
        /// </summary>
        public const string Searchengin = "\uf3eb";

        /// <summary>
        /// fa-seedling unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/seedling
        /// </summary>
        public const string Seedling = "\uf4d8";

        /// <summary>
        /// fa-sellcast unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sellcast
        /// </summary>
        public const string Sellcast = "\uf2da";

        /// <summary>
        /// fa-sellsy unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sellsy
        /// </summary>
        public const string Sellsy = "\uf213";

        /// <summary>
        /// fa-server unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/server
        /// </summary>
        public const string Server = "\uf233";

        /// <summary>
        /// fa-servicestack unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/servicestack
        /// </summary>
        public const string Servicestack = "\uf3ec";

        /// <summary>
        /// fa-shapes unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shapes
        /// </summary>
        public const string Shapes = "\uf61f";

        /// <summary>
        /// fa-share unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/share
        /// </summary>
        public const string Share = "\uf064";

        /// <summary>
        /// fa-share-all unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/share-all
        /// </summary>
        public const string ShareAll = "\uf367";

        /// <summary>
        /// fa-share-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/share-alt
        /// </summary>
        public const string ShareAlt = "\uf1e0";

        /// <summary>
        /// fa-share-alt-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/share-alt-square
        /// </summary>
        public const string ShareAltSquare = "\uf1e1";

        /// <summary>
        /// fa-share-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/share-square
        /// </summary>
        public const string ShareSquare = "\uf14d";

        /// <summary>
        /// fa-sheep unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sheep
        /// </summary>
        public const string Sheep = "\uf711";

        /// <summary>
        /// fa-shekel-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shekel-sign
        /// </summary>
        public const string ShekelSign = "\uf20b";

        /// <summary>
        /// fa-shield unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shield
        /// </summary>
        public const string Shield = "\uf132";

        /// <summary>
        /// fa-shield-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shield-alt
        /// </summary>
        public const string ShieldAlt = "\uf3ed";

        /// <summary>
        /// fa-shield-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shield-check
        /// </summary>
        public const string ShieldCheck = "\uf2f7";

        /// <summary>
        /// fa-shield-cross unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shield-cross
        /// </summary>
        public const string ShieldCross = "\uf712";

        /// <summary>
        /// fa-ship unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ship
        /// </summary>
        public const string Ship = "\uf21a";

        /// <summary>
        /// fa-shipping-fast unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shipping-fast
        /// </summary>
        public const string ShippingFast = "\uf48b";

        /// <summary>
        /// fa-shipping-timed unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shipping-timed
        /// </summary>
        public const string ShippingTimed = "\uf48c";

        /// <summary>
        /// fa-shirtsinbulk unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/shirtsinbulk
        /// </summary>
        public const string Shirtsinbulk = "\uf214";

        /// <summary>
        /// fa-shoe-prints unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shoe-prints
        /// </summary>
        public const string ShoePrints = "\uf54b";

        /// <summary>
        /// fa-shopping-bag unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shopping-bag
        /// </summary>
        public const string ShoppingBag = "\uf290";

        /// <summary>
        /// fa-shopping-basket unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shopping-basket
        /// </summary>
        public const string ShoppingBasket = "\uf291";

        /// <summary>
        /// fa-shopping-cart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shopping-cart
        /// </summary>
        public const string ShoppingCart = "\uf07a";

        /// <summary>
        /// fa-shopware unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/shopware
        /// </summary>
        public const string Shopware = "\uf5b5";

        /// <summary>
        /// fa-shovel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shovel
        /// </summary>
        public const string Shovel = "\uf713";

        /// <summary>
        /// fa-shower unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shower
        /// </summary>
        public const string Shower = "\uf2cc";

        /// <summary>
        /// fa-shredder unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shredder
        /// </summary>
        public const string Shredder = "\uf68a";

        /// <summary>
        /// fa-shuttle-van unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/shuttle-van
        /// </summary>
        public const string ShuttleVan = "\uf5b6";

        /// <summary>
        /// fa-shuttlecock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/shuttlecock
        /// </summary>
        public const string Shuttlecock = "\uf45b";

        /// <summary>
        /// fa-sigma unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sigma
        /// </summary>
        public const string Sigma = "\uf68b";

        /// <summary>
        /// fa-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sign
        /// </summary>
        public const string Sign = "\uf4d9";

        /// <summary>
        /// fa-sign-in unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sign-in
        /// </summary>
        public const string SignIn = "\uf090";

        /// <summary>
        /// fa-sign-in-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sign-in-alt
        /// </summary>
        public const string SignInAlt = "\uf2f6";

        /// <summary>
        /// fa-sign-language unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sign-language
        /// </summary>
        public const string SignLanguage = "\uf2a7";

        /// <summary>
        /// fa-sign-out unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sign-out
        /// </summary>
        public const string SignOut = "\uf08b";

        /// <summary>
        /// fa-sign-out-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sign-out-alt
        /// </summary>
        public const string SignOutAlt = "\uf2f5";

        /// <summary>
        /// fa-signal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/signal
        /// </summary>
        public const string Signal = "\uf012";

        /// <summary>
        /// fa-signal-1 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-1
        /// </summary>
        public const string Signal1 = "\uf68c";

        /// <summary>
        /// fa-signal-2 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-2
        /// </summary>
        public const string Signal2 = "\uf68d";

        /// <summary>
        /// fa-signal-3 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-3
        /// </summary>
        public const string Signal3 = "\uf68e";

        /// <summary>
        /// fa-signal-4 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-4
        /// </summary>
        public const string Signal4 = "\uf68f";

        /// <summary>
        /// fa-signal-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-alt
        /// </summary>
        public const string SignalAlt = "\uf690";

        /// <summary>
        /// fa-signal-alt-1 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-alt-1
        /// </summary>
        public const string SignalAlt1 = "\uf691";

        /// <summary>
        /// fa-signal-alt-2 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-alt-2
        /// </summary>
        public const string SignalAlt2 = "\uf692";

        /// <summary>
        /// fa-signal-alt-3 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-alt-3
        /// </summary>
        public const string SignalAlt3 = "\uf693";

        /// <summary>
        /// fa-signal-alt-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-alt-slash
        /// </summary>
        public const string SignalAltSlash = "\uf694";

        /// <summary>
        /// fa-signal-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/signal-slash
        /// </summary>
        public const string SignalSlash = "\uf695";

        /// <summary>
        /// fa-signature unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/signature
        /// </summary>
        public const string Signature = "\uf5b7";

        /// <summary>
        /// fa-simplybuilt unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/simplybuilt
        /// </summary>
        public const string Simplybuilt = "\uf215";

        /// <summary>
        /// fa-sistrix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sistrix
        /// </summary>
        public const string Sistrix = "\uf3ee";

        /// <summary>
        /// fa-sitemap unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sitemap
        /// </summary>
        public const string Sitemap = "\uf0e8";

        /// <summary>
        /// fa-sith unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sith
        /// </summary>
        public const string Sith = "\uf512";

        /// <summary>
        /// fa-skeleton unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/skeleton
        /// </summary>
        public const string Skeleton = "\uf620";

        /// <summary>
        /// fa-skull unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/skull
        /// </summary>
        public const string Skull = "\uf54c";

        /// <summary>
        /// fa-skull-crossbones unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/skull-crossbones
        /// </summary>
        public const string SkullCrossbones = "\uf714";

        /// <summary>
        /// fa-skyatlas unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/skyatlas
        /// </summary>
        public const string Skyatlas = "\uf216";

        /// <summary>
        /// fa-skype unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/skype
        /// </summary>
        public const string Skype = "\uf17e";

        /// <summary>
        /// fa-slack unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/slack
        /// </summary>
        public const string Slack = "\uf198";

        /// <summary>
        /// fa-slack-hash unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/slack-hash
        /// </summary>
        public const string SlackHash = "\uf3ef";

        /// <summary>
        /// fa-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/slash
        /// </summary>
        public const string Slash = "\uf715";

        /// <summary>
        /// fa-sliders-h unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sliders-h
        /// </summary>
        public const string SlidersH = "\uf1de";

        /// <summary>
        /// fa-sliders-h-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sliders-h-square
        /// </summary>
        public const string SlidersHSquare = "\uf3f0";

        /// <summary>
        /// fa-sliders-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sliders-v
        /// </summary>
        public const string SlidersV = "\uf3f1";

        /// <summary>
        /// fa-sliders-v-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sliders-v-square
        /// </summary>
        public const string SlidersVSquare = "\uf3f2";

        /// <summary>
        /// fa-slideshare unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/slideshare
        /// </summary>
        public const string Slideshare = "\uf1e7";

        /// <summary>
        /// fa-smile unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smile
        /// </summary>
        public const string Smile = "\uf118";

        /// <summary>
        /// fa-smile-beam unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smile-beam
        /// </summary>
        public const string SmileBeam = "\uf5b8";

        /// <summary>
        /// fa-smile-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/smile-plus
        /// </summary>
        public const string SmilePlus = "\uf5b9";

        /// <summary>
        /// fa-smile-wink unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smile-wink
        /// </summary>
        public const string SmileWink = "\uf4da";

        /// <summary>
        /// fa-smog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smog
        /// </summary>
        public const string Smog = "\uf75f";

        /// <summary>
        /// fa-smoke unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/smoke
        /// </summary>
        public const string Smoke = "\uf760";

        /// <summary>
        /// fa-smoking unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smoking
        /// </summary>
        public const string Smoking = "\uf48d";

        /// <summary>
        /// fa-smoking-ban unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/smoking-ban
        /// </summary>
        public const string SmokingBan = "\uf54d";

        /// <summary>
        /// fa-snake unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/snake
        /// </summary>
        public const string Snake = "\uf716";

        /// <summary>
        /// fa-snapchat unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/snapchat
        /// </summary>
        public const string Snapchat = "\uf2ab";

        /// <summary>
        /// fa-snapchat-ghost unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/snapchat-ghost
        /// </summary>
        public const string SnapchatGhost = "\uf2ac";

        /// <summary>
        /// fa-snapchat-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/snapchat-square
        /// </summary>
        public const string SnapchatSquare = "\uf2ad";

        /// <summary>
        /// fa-snow-blowing unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/snow-blowing
        /// </summary>
        public const string SnowBlowing = "\uf761";

        /// <summary>
        /// fa-snowflake unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/snowflake
        /// </summary>
        public const string Snowflake = "\uf2dc";

        /// <summary>
        /// fa-socks unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/socks
        /// </summary>
        public const string Socks = "\uf696";

        /// <summary>
        /// fa-solar-panel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/solar-panel
        /// </summary>
        public const string SolarPanel = "\uf5ba";

        /// <summary>
        /// fa-sort unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort
        /// </summary>
        public const string Sort = "\uf0dc";

        /// <summary>
        /// fa-sort-alpha-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-alpha-down
        /// </summary>
        public const string SortAlphaDown = "\uf15d";

        /// <summary>
        /// fa-sort-alpha-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-alpha-up
        /// </summary>
        public const string SortAlphaUp = "\uf15e";

        /// <summary>
        /// fa-sort-amount-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-amount-down
        /// </summary>
        public const string SortAmountDown = "\uf160";

        /// <summary>
        /// fa-sort-amount-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-amount-up
        /// </summary>
        public const string SortAmountUp = "\uf161";

        /// <summary>
        /// fa-sort-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-down
        /// </summary>
        public const string SortDown = "\uf0dd";

        /// <summary>
        /// fa-sort-numeric-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-numeric-down
        /// </summary>
        public const string SortNumericDown = "\uf162";

        /// <summary>
        /// fa-sort-numeric-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-numeric-up
        /// </summary>
        public const string SortNumericUp = "\uf163";

        /// <summary>
        /// fa-sort-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sort-up
        /// </summary>
        public const string SortUp = "\uf0de";

        /// <summary>
        /// fa-soundcloud unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/soundcloud
        /// </summary>
        public const string Soundcloud = "\uf1be";

        /// <summary>
        /// fa-spa unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/spa
        /// </summary>
        public const string Spa = "\uf5bb";

        /// <summary>
        /// fa-space-shuttle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/space-shuttle
        /// </summary>
        public const string SpaceShuttle = "\uf197";

        /// <summary>
        /// fa-spade unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/spade
        /// </summary>
        public const string Spade = "\uf2f4";

        /// <summary>
        /// fa-speakap unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/speakap
        /// </summary>
        public const string Speakap = "\uf3f3";

        /// <summary>
        /// fa-spider unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/spider
        /// </summary>
        public const string Spider = "\uf717";

        /// <summary>
        /// fa-spider-black-widow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/spider-black-widow
        /// </summary>
        public const string SpiderBlackWidow = "\uf718";

        /// <summary>
        /// fa-spider-web unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/spider-web
        /// </summary>
        public const string SpiderWeb = "\uf719";

        /// <summary>
        /// fa-spinner unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/spinner
        /// </summary>
        public const string Spinner = "\uf110";

        /// <summary>
        /// fa-spinner-third unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/spinner-third
        /// </summary>
        public const string SpinnerThird = "\uf3f4";

        /// <summary>
        /// fa-splotch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/splotch
        /// </summary>
        public const string Splotch = "\uf5bc";

        /// <summary>
        /// fa-spotify unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/spotify
        /// </summary>
        public const string Spotify = "\uf1bc";

        /// <summary>
        /// fa-spray-can unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/spray-can
        /// </summary>
        public const string SprayCan = "\uf5bd";

        /// <summary>
        /// fa-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/square
        /// </summary>
        public const string Square = "\uf0c8";

        /// <summary>
        /// fa-square-full unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/square-full
        /// </summary>
        public const string SquareFull = "\uf45c";

        /// <summary>
        /// fa-square-root unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/square-root
        /// </summary>
        public const string SquareRoot = "\uf697";

        /// <summary>
        /// fa-square-root-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/square-root-alt
        /// </summary>
        public const string SquareRootAlt = "\uf698";

        /// <summary>
        /// fa-squarespace unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/squarespace
        /// </summary>
        public const string Squarespace = "\uf5be";

        /// <summary>
        /// fa-squirrel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/squirrel
        /// </summary>
        public const string Squirrel = "\uf71a";

        /// <summary>
        /// fa-stack-exchange unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stack-exchange
        /// </summary>
        public const string StackExchange = "\uf18d";

        /// <summary>
        /// fa-stack-overflow unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stack-overflow
        /// </summary>
        public const string StackOverflow = "\uf16c";

        /// <summary>
        /// fa-staff unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/staff
        /// </summary>
        public const string Staff = "\uf71b";

        /// <summary>
        /// fa-stamp unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stamp
        /// </summary>
        public const string Stamp = "\uf5bf";

        /// <summary>
        /// fa-star unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star
        /// </summary>
        public const string Star = "\uf005";

        /// <summary>
        /// fa-star-and-crescent unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star-and-crescent
        /// </summary>
        public const string StarAndCrescent = "\uf699";

        /// <summary>
        /// fa-star-exclamation unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/star-exclamation
        /// </summary>
        public const string StarExclamation = "\uf2f3";

        /// <summary>
        /// fa-star-half unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star-half
        /// </summary>
        public const string StarHalf = "\uf089";

        /// <summary>
        /// fa-star-half-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star-half-alt
        /// </summary>
        public const string StarHalfAlt = "\uf5c0";

        /// <summary>
        /// fa-star-of-david unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star-of-david
        /// </summary>
        public const string StarOfDavid = "\uf69a";

        /// <summary>
        /// fa-star-of-life unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/star-of-life
        /// </summary>
        public const string StarOfLife = "\uf621";

        /// <summary>
        /// fa-stars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/stars
        /// </summary>
        public const string Stars = "\uf762";

        /// <summary>
        /// fa-staylinked unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/staylinked
        /// </summary>
        public const string Staylinked = "\uf3f5";

        /// <summary>
        /// fa-steam unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/steam
        /// </summary>
        public const string Steam = "\uf1b6";

        /// <summary>
        /// fa-steam-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/steam-square
        /// </summary>
        public const string SteamSquare = "\uf1b7";

        /// <summary>
        /// fa-steam-symbol unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/steam-symbol
        /// </summary>
        public const string SteamSymbol = "\uf3f6";

        /// <summary>
        /// fa-steering-wheel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/steering-wheel
        /// </summary>
        public const string SteeringWheel = "\uf622";

        /// <summary>
        /// fa-step-backward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/step-backward
        /// </summary>
        public const string StepBackward = "\uf048";

        /// <summary>
        /// fa-step-forward unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/step-forward
        /// </summary>
        public const string StepForward = "\uf051";

        /// <summary>
        /// fa-stethoscope unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stethoscope
        /// </summary>
        public const string Stethoscope = "\uf0f1";

        /// <summary>
        /// fa-sticker-mule unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/sticker-mule
        /// </summary>
        public const string StickerMule = "\uf3f7";

        /// <summary>
        /// fa-sticky-note unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sticky-note
        /// </summary>
        public const string StickyNote = "\uf249";

        /// <summary>
        /// fa-stomach unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/stomach
        /// </summary>
        public const string Stomach = "\uf623";

        /// <summary>
        /// fa-stop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stop
        /// </summary>
        public const string Stop = "\uf04d";

        /// <summary>
        /// fa-stop-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stop-circle
        /// </summary>
        public const string StopCircle = "\uf28d";

        /// <summary>
        /// fa-stopwatch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stopwatch
        /// </summary>
        public const string Stopwatch = "\uf2f2";

        /// <summary>
        /// fa-store unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/store
        /// </summary>
        public const string Store = "\uf54e";

        /// <summary>
        /// fa-store-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/store-alt
        /// </summary>
        public const string StoreAlt = "\uf54f";

        /// <summary>
        /// fa-strava unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/strava
        /// </summary>
        public const string Strava = "\uf428";

        /// <summary>
        /// fa-stream unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stream
        /// </summary>
        public const string Stream = "\uf550";

        /// <summary>
        /// fa-street-view unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/street-view
        /// </summary>
        public const string StreetView = "\uf21d";

        /// <summary>
        /// fa-strikethrough unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/strikethrough
        /// </summary>
        public const string Strikethrough = "\uf0cc";

        /// <summary>
        /// fa-stripe unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stripe
        /// </summary>
        public const string Stripe = "\uf429";

        /// <summary>
        /// fa-stripe-s unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stripe-s
        /// </summary>
        public const string StripeS = "\uf42a";

        /// <summary>
        /// fa-stroopwafel unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/stroopwafel
        /// </summary>
        public const string Stroopwafel = "\uf551";

        /// <summary>
        /// fa-studiovinari unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/studiovinari
        /// </summary>
        public const string Studiovinari = "\uf3f8";

        /// <summary>
        /// fa-stumbleupon unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stumbleupon
        /// </summary>
        public const string Stumbleupon = "\uf1a4";

        /// <summary>
        /// fa-stumbleupon-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/stumbleupon-circle
        /// </summary>
        public const string StumbleuponCircle = "\uf1a3";

        /// <summary>
        /// fa-subscript unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/subscript
        /// </summary>
        public const string Subscript = "\uf12c";

        /// <summary>
        /// fa-subway unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/subway
        /// </summary>
        public const string Subway = "\uf239";

        /// <summary>
        /// fa-suitcase unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/suitcase
        /// </summary>
        public const string Suitcase = "\uf0f2";

        /// <summary>
        /// fa-suitcase-rolling unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/suitcase-rolling
        /// </summary>
        public const string SuitcaseRolling = "\uf5c1";

        /// <summary>
        /// fa-sun unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sun
        /// </summary>
        public const string Sun = "\uf185";

        /// <summary>
        /// fa-sun-cloud unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sun-cloud
        /// </summary>
        public const string SunCloud = "\uf763";

        /// <summary>
        /// fa-sun-dust unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sun-dust
        /// </summary>
        public const string SunDust = "\uf764";

        /// <summary>
        /// fa-sun-haze unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sun-haze
        /// </summary>
        public const string SunHaze = "\uf765";

        /// <summary>
        /// fa-sunrise unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sunrise
        /// </summary>
        public const string Sunrise = "\uf766";

        /// <summary>
        /// fa-sunset unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sunset
        /// </summary>
        public const string Sunset = "\uf767";

        /// <summary>
        /// fa-superpowers unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/superpowers
        /// </summary>
        public const string Superpowers = "\uf2dd";

        /// <summary>
        /// fa-superscript unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/superscript
        /// </summary>
        public const string Superscript = "\uf12b";

        /// <summary>
        /// fa-supple unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/supple
        /// </summary>
        public const string Supple = "\uf3f9";

        /// <summary>
        /// fa-surprise unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/surprise
        /// </summary>
        public const string Surprise = "\uf5c2";

        /// <summary>
        /// fa-swatchbook unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/swatchbook
        /// </summary>
        public const string Swatchbook = "\uf5c3";

        /// <summary>
        /// fa-swimmer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/swimmer
        /// </summary>
        public const string Swimmer = "\uf5c4";

        /// <summary>
        /// fa-swimming-pool unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/swimming-pool
        /// </summary>
        public const string SwimmingPool = "\uf5c5";

        /// <summary>
        /// fa-sword unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/sword
        /// </summary>
        public const string Sword = "\uf71c";

        /// <summary>
        /// fa-swords unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/swords
        /// </summary>
        public const string Swords = "\uf71d";

        /// <summary>
        /// fa-synagogue unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/synagogue
        /// </summary>
        public const string Synagogue = "\uf69b";

        /// <summary>
        /// fa-sync unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sync
        /// </summary>
        public const string Sync = "\uf021";

        /// <summary>
        /// fa-sync-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/sync-alt
        /// </summary>
        public const string SyncAlt = "\uf2f1";

        /// <summary>
        /// fa-syringe unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/syringe
        /// </summary>
        public const string Syringe = "\uf48e";

        /// <summary>
        /// fa-table unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/table
        /// </summary>
        public const string Table = "\uf0ce";

        /// <summary>
        /// fa-table-tennis unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/table-tennis
        /// </summary>
        public const string TableTennis = "\uf45d";

        /// <summary>
        /// fa-tablet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tablet
        /// </summary>
        public const string Tablet = "\uf10a";

        /// <summary>
        /// fa-tablet-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tablet-alt
        /// </summary>
        public const string TabletAlt = "\uf3fa";

        /// <summary>
        /// fa-tablet-android unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tablet-android
        /// </summary>
        public const string TabletAndroid = "\uf3fb";

        /// <summary>
        /// fa-tablet-android-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tablet-android-alt
        /// </summary>
        public const string TabletAndroidAlt = "\uf3fc";

        /// <summary>
        /// fa-tablet-rugged unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tablet-rugged
        /// </summary>
        public const string TabletRugged = "\uf48f";

        /// <summary>
        /// fa-tablets unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tablets
        /// </summary>
        public const string Tablets = "\uf490";

        /// <summary>
        /// fa-tachometer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer
        /// </summary>
        public const string Tachometer = "\uf0e4";

        /// <summary>
        /// fa-tachometer-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt
        /// </summary>
        public const string TachometerAlt = "\uf3fd";

        /// <summary>
        /// fa-tachometer-alt-average unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt-average
        /// </summary>
        public const string TachometerAltAverage = "\uf624";

        /// <summary>
        /// fa-tachometer-alt-fast unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt-fast
        /// </summary>
        public const string TachometerAltFast = "\uf625";

        /// <summary>
        /// fa-tachometer-alt-fastest unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt-fastest
        /// </summary>
        public const string TachometerAltFastest = "\uf626";

        /// <summary>
        /// fa-tachometer-alt-slow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt-slow
        /// </summary>
        public const string TachometerAltSlow = "\uf627";

        /// <summary>
        /// fa-tachometer-alt-slowest unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-alt-slowest
        /// </summary>
        public const string TachometerAltSlowest = "\uf628";

        /// <summary>
        /// fa-tachometer-average unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-average
        /// </summary>
        public const string TachometerAverage = "\uf629";

        /// <summary>
        /// fa-tachometer-fast unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-fast
        /// </summary>
        public const string TachometerFast = "\uf62a";

        /// <summary>
        /// fa-tachometer-fastest unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-fastest
        /// </summary>
        public const string TachometerFastest = "\uf62b";

        /// <summary>
        /// fa-tachometer-slow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-slow
        /// </summary>
        public const string TachometerSlow = "\uf62c";

        /// <summary>
        /// fa-tachometer-slowest unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tachometer-slowest
        /// </summary>
        public const string TachometerSlowest = "\uf62d";

        /// <summary>
        /// fa-tag unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tag
        /// </summary>
        public const string Tag = "\uf02b";

        /// <summary>
        /// fa-tags unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tags
        /// </summary>
        public const string Tags = "\uf02c";

        /// <summary>
        /// fa-tally unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tally
        /// </summary>
        public const string Tally = "\uf69c";

        /// <summary>
        /// fa-tape unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tape
        /// </summary>
        public const string Tape = "\uf4db";

        /// <summary>
        /// fa-tasks unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tasks
        /// </summary>
        public const string Tasks = "\uf0ae";

        /// <summary>
        /// fa-taxi unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/taxi
        /// </summary>
        public const string Taxi = "\uf1ba";

        /// <summary>
        /// fa-teamspeak unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/teamspeak
        /// </summary>
        public const string Teamspeak = "\uf4f9";

        /// <summary>
        /// fa-teeth unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/teeth
        /// </summary>
        public const string Teeth = "\uf62e";

        /// <summary>
        /// fa-teeth-open unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/teeth-open
        /// </summary>
        public const string TeethOpen = "\uf62f";

        /// <summary>
        /// fa-telegram unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/telegram
        /// </summary>
        public const string Telegram = "\uf2c6";

        /// <summary>
        /// fa-telegram-plane unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/telegram-plane
        /// </summary>
        public const string TelegramPlane = "\uf3fe";

        /// <summary>
        /// fa-temperature-frigid unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/temperature-frigid
        /// </summary>
        public const string TemperatureFrigid = "\uf768";

        /// <summary>
        /// fa-temperature-high unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/temperature-high
        /// </summary>
        public const string TemperatureHigh = "\uf769";

        /// <summary>
        /// fa-temperature-hot unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/temperature-hot
        /// </summary>
        public const string TemperatureHot = "\uf76a";

        /// <summary>
        /// fa-temperature-low unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/temperature-low
        /// </summary>
        public const string TemperatureLow = "\uf76b";

        /// <summary>
        /// fa-tencent-weibo unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/tencent-weibo
        /// </summary>
        public const string TencentWeibo = "\uf1d5";

        /// <summary>
        /// fa-tennis-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tennis-ball
        /// </summary>
        public const string TennisBall = "\uf45e";

        /// <summary>
        /// fa-terminal unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/terminal
        /// </summary>
        public const string Terminal = "\uf120";

        /// <summary>
        /// fa-text-height unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/text-height
        /// </summary>
        public const string TextHeight = "\uf034";

        /// <summary>
        /// fa-text-width unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/text-width
        /// </summary>
        public const string TextWidth = "\uf035";

        /// <summary>
        /// fa-th unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/th
        /// </summary>
        public const string Th = "\uf00a";

        /// <summary>
        /// fa-th-large unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/th-large
        /// </summary>
        public const string ThLarge = "\uf009";

        /// <summary>
        /// fa-th-list unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/th-list
        /// </summary>
        public const string ThList = "\uf00b";

        /// <summary>
        /// fa-the-red-yeti unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/the-red-yeti
        /// </summary>
        public const string TheRedYeti = "\uf69d";

        /// <summary>
        /// fa-theater-masks unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/theater-masks
        /// </summary>
        public const string TheaterMasks = "\uf630";

        /// <summary>
        /// fa-themeco unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/themeco
        /// </summary>
        public const string Themeco = "\uf5c6";

        /// <summary>
        /// fa-themeisle unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/themeisle
        /// </summary>
        public const string Themeisle = "\uf2b2";

        /// <summary>
        /// fa-thermometer unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer
        /// </summary>
        public const string Thermometer = "\uf491";

        /// <summary>
        /// fa-thermometer-empty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer-empty
        /// </summary>
        public const string ThermometerEmpty = "\uf2cb";

        /// <summary>
        /// fa-thermometer-full unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer-full
        /// </summary>
        public const string ThermometerFull = "\uf2c7";

        /// <summary>
        /// fa-thermometer-half unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer-half
        /// </summary>
        public const string ThermometerHalf = "\uf2c9";

        /// <summary>
        /// fa-thermometer-quarter unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer-quarter
        /// </summary>
        public const string ThermometerQuarter = "\uf2ca";

        /// <summary>
        /// fa-thermometer-three-quarters unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thermometer-three-quarters
        /// </summary>
        public const string ThermometerThreeQuarters = "\uf2c8";

        /// <summary>
        /// fa-theta unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/theta
        /// </summary>
        public const string Theta = "\uf69e";

        /// <summary>
        /// fa-think-peaks unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/think-peaks
        /// </summary>
        public const string ThinkPeaks = "\uf731";

        /// <summary>
        /// fa-thumbs-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thumbs-down
        /// </summary>
        public const string ThumbsDown = "\uf165";

        /// <summary>
        /// fa-thumbs-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thumbs-up
        /// </summary>
        public const string ThumbsUp = "\uf164";

        /// <summary>
        /// fa-thumbtack unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/thumbtack
        /// </summary>
        public const string Thumbtack = "\uf08d";

        /// <summary>
        /// fa-thunderstorm unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/thunderstorm
        /// </summary>
        public const string Thunderstorm = "\uf76c";

        /// <summary>
        /// fa-thunderstorm-moon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/thunderstorm-moon
        /// </summary>
        public const string ThunderstormMoon = "\uf76d";

        /// <summary>
        /// fa-thunderstorm-sun unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/thunderstorm-sun
        /// </summary>
        public const string ThunderstormSun = "\uf76e";

        /// <summary>
        /// fa-ticket unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/ticket
        /// </summary>
        public const string Ticket = "\uf145";

        /// <summary>
        /// fa-ticket-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/ticket-alt
        /// </summary>
        public const string TicketAlt = "\uf3ff";

        /// <summary>
        /// fa-tilde unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tilde
        /// </summary>
        public const string Tilde = "\uf69f";

        /// <summary>
        /// fa-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/times
        /// </summary>
        public const string Times = "\uf00d";

        /// <summary>
        /// fa-times-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/times-circle
        /// </summary>
        public const string TimesCircle = "\uf057";

        /// <summary>
        /// fa-times-hexagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/times-hexagon
        /// </summary>
        public const string TimesHexagon = "\uf2ee";

        /// <summary>
        /// fa-times-octagon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/times-octagon
        /// </summary>
        public const string TimesOctagon = "\uf2f0";

        /// <summary>
        /// fa-times-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/times-square
        /// </summary>
        public const string TimesSquare = "\uf2d3";

        /// <summary>
        /// fa-tint unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tint
        /// </summary>
        public const string Tint = "\uf043";

        /// <summary>
        /// fa-tint-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tint-slash
        /// </summary>
        public const string TintSlash = "\uf5c7";

        /// <summary>
        /// fa-tire unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tire
        /// </summary>
        public const string Tire = "\uf631";

        /// <summary>
        /// fa-tire-flat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tire-flat
        /// </summary>
        public const string TireFlat = "\uf632";

        /// <summary>
        /// fa-tire-pressure-warning unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tire-pressure-warning
        /// </summary>
        public const string TirePressureWarning = "\uf633";

        /// <summary>
        /// fa-tire-rugged unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tire-rugged
        /// </summary>
        public const string TireRugged = "\uf634";

        /// <summary>
        /// fa-tired unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tired
        /// </summary>
        public const string Tired = "\uf5c8";

        /// <summary>
        /// fa-toggle-off unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/toggle-off
        /// </summary>
        public const string ToggleOff = "\uf204";

        /// <summary>
        /// fa-toggle-on unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/toggle-on
        /// </summary>
        public const string ToggleOn = "\uf205";

        /// <summary>
        /// fa-toilet-paper unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/toilet-paper
        /// </summary>
        public const string ToiletPaper = "\uf71e";

        /// <summary>
        /// fa-toilet-paper-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/toilet-paper-alt
        /// </summary>
        public const string ToiletPaperAlt = "\uf71f";

        /// <summary>
        /// fa-tombstone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tombstone
        /// </summary>
        public const string Tombstone = "\uf720";

        /// <summary>
        /// fa-tombstone-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tombstone-alt
        /// </summary>
        public const string TombstoneAlt = "\uf721";

        /// <summary>
        /// fa-toolbox unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/toolbox
        /// </summary>
        public const string Toolbox = "\uf552";

        /// <summary>
        /// fa-tooth unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tooth
        /// </summary>
        public const string Tooth = "\uf5c9";

        /// <summary>
        /// fa-toothbrush unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/toothbrush
        /// </summary>
        public const string Toothbrush = "\uf635";

        /// <summary>
        /// fa-torah unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/torah
        /// </summary>
        public const string Torah = "\uf6a0";

        /// <summary>
        /// fa-torii-gate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/torii-gate
        /// </summary>
        public const string ToriiGate = "\uf6a1";

        /// <summary>
        /// fa-tornado unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tornado
        /// </summary>
        public const string Tornado = "\uf76f";

        /// <summary>
        /// fa-tractor unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tractor
        /// </summary>
        public const string Tractor = "\uf722";

        /// <summary>
        /// fa-trade-federation unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/trade-federation
        /// </summary>
        public const string TradeFederation = "\uf513";

        /// <summary>
        /// fa-trademark unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/trademark
        /// </summary>
        public const string Trademark = "\uf25c";

        /// <summary>
        /// fa-traffic-cone unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/traffic-cone
        /// </summary>
        public const string TrafficCone = "\uf636";

        /// <summary>
        /// fa-traffic-light unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/traffic-light
        /// </summary>
        public const string TrafficLight = "\uf637";

        /// <summary>
        /// fa-traffic-light-go unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/traffic-light-go
        /// </summary>
        public const string TrafficLightGo = "\uf638";

        /// <summary>
        /// fa-traffic-light-slow unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/traffic-light-slow
        /// </summary>
        public const string TrafficLightSlow = "\uf639";

        /// <summary>
        /// fa-traffic-light-stop unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/traffic-light-stop
        /// </summary>
        public const string TrafficLightStop = "\uf63a";

        /// <summary>
        /// fa-train unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/train
        /// </summary>
        public const string Train = "\uf238";

        /// <summary>
        /// fa-transgender unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/transgender
        /// </summary>
        public const string Transgender = "\uf224";

        /// <summary>
        /// fa-transgender-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/transgender-alt
        /// </summary>
        public const string TransgenderAlt = "\uf225";

        /// <summary>
        /// fa-trash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/trash
        /// </summary>
        public const string Trash = "\uf1f8";

        /// <summary>
        /// fa-trash-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/trash-alt
        /// </summary>
        public const string TrashAlt = "\uf2ed";

        /// <summary>
        /// fa-treasure-chest unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/treasure-chest
        /// </summary>
        public const string TreasureChest = "\uf723";

        /// <summary>
        /// fa-tree unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tree
        /// </summary>
        public const string Tree = "\uf1bb";

        /// <summary>
        /// fa-tree-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tree-alt
        /// </summary>
        public const string TreeAlt = "\uf400";

        /// <summary>
        /// fa-trees unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/trees
        /// </summary>
        public const string Trees = "\uf724";

        /// <summary>
        /// fa-trello unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/trello
        /// </summary>
        public const string Trello = "\uf181";

        /// <summary>
        /// fa-triangle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/triangle
        /// </summary>
        public const string Triangle = "\uf2ec";

        /// <summary>
        /// fa-tripadvisor unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/tripadvisor
        /// </summary>
        public const string Tripadvisor = "\uf262";

        /// <summary>
        /// fa-trophy unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/trophy
        /// </summary>
        public const string Trophy = "\uf091";

        /// <summary>
        /// fa-trophy-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/trophy-alt
        /// </summary>
        public const string TrophyAlt = "\uf2eb";

        /// <summary>
        /// fa-truck unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/truck
        /// </summary>
        public const string Truck = "\uf0d1";

        /// <summary>
        /// fa-truck-container unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/truck-container
        /// </summary>
        public const string TruckContainer = "\uf4dc";

        /// <summary>
        /// fa-truck-couch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/truck-couch
        /// </summary>
        public const string TruckCouch = "\uf4dd";

        /// <summary>
        /// fa-truck-loading unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/truck-loading
        /// </summary>
        public const string TruckLoading = "\uf4de";

        /// <summary>
        /// fa-truck-monster unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/truck-monster
        /// </summary>
        public const string TruckMonster = "\uf63b";

        /// <summary>
        /// fa-truck-moving unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/truck-moving
        /// </summary>
        public const string TruckMoving = "\uf4df";

        /// <summary>
        /// fa-truck-pickup unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/truck-pickup
        /// </summary>
        public const string TruckPickup = "\uf63c";

        /// <summary>
        /// fa-truck-ramp unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/truck-ramp
        /// </summary>
        public const string TruckRamp = "\uf4e0";

        /// <summary>
        /// fa-tshirt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tshirt
        /// </summary>
        public const string Tshirt = "\uf553";

        /// <summary>
        /// fa-tty unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tty
        /// </summary>
        public const string Tty = "\uf1e4";

        /// <summary>
        /// fa-tumblr unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/tumblr
        /// </summary>
        public const string Tumblr = "\uf173";

        /// <summary>
        /// fa-tumblr-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/tumblr-square
        /// </summary>
        public const string TumblrSquare = "\uf174";

        /// <summary>
        /// fa-turkey unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/turkey
        /// </summary>
        public const string Turkey = "\uf725";

        /// <summary>
        /// fa-turtle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/turtle
        /// </summary>
        public const string Turtle = "\uf726";

        /// <summary>
        /// fa-tv unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/tv
        /// </summary>
        public const string Tv = "\uf26c";

        /// <summary>
        /// fa-tv-retro unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/tv-retro
        /// </summary>
        public const string TvRetro = "\uf401";

        /// <summary>
        /// fa-twitch unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/twitch
        /// </summary>
        public const string Twitch = "\uf1e8";

        /// <summary>
        /// fa-twitter unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/twitter
        /// </summary>
        public const string Twitter = "\uf099";

        /// <summary>
        /// fa-twitter-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/twitter-square
        /// </summary>
        public const string TwitterSquare = "\uf081";

        /// <summary>
        /// fa-typo3 unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/typo3
        /// </summary>
        public const string Typo3 = "\uf42b";

        /// <summary>
        /// fa-uber unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/uber
        /// </summary>
        public const string Uber = "\uf402";

        /// <summary>
        /// fa-uikit unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/uikit
        /// </summary>
        public const string Uikit = "\uf403";

        /// <summary>
        /// fa-umbrella unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/umbrella
        /// </summary>
        public const string Umbrella = "\uf0e9";

        /// <summary>
        /// fa-umbrella-beach unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/umbrella-beach
        /// </summary>
        public const string UmbrellaBeach = "\uf5ca";

        /// <summary>
        /// fa-underline unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/underline
        /// </summary>
        public const string Underline = "\uf0cd";

        /// <summary>
        /// fa-undo unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/undo
        /// </summary>
        public const string Undo = "\uf0e2";

        /// <summary>
        /// fa-undo-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/undo-alt
        /// </summary>
        public const string UndoAlt = "\uf2ea";

        /// <summary>
        /// fa-unicorn unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/unicorn
        /// </summary>
        public const string Unicorn = "\uf727";

        /// <summary>
        /// fa-union unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/union
        /// </summary>
        public const string Union = "\uf6a2";

        /// <summary>
        /// fa-uniregistry unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/uniregistry
        /// </summary>
        public const string Uniregistry = "\uf404";

        /// <summary>
        /// fa-universal-access unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/universal-access
        /// </summary>
        public const string UniversalAccess = "\uf29a";

        /// <summary>
        /// fa-university unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/university
        /// </summary>
        public const string University = "\uf19c";

        /// <summary>
        /// fa-unlink unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/unlink
        /// </summary>
        public const string Unlink = "\uf127";

        /// <summary>
        /// fa-unlock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/unlock
        /// </summary>
        public const string Unlock = "\uf09c";

        /// <summary>
        /// fa-unlock-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/unlock-alt
        /// </summary>
        public const string UnlockAlt = "\uf13e";

        /// <summary>
        /// fa-untappd unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/untappd
        /// </summary>
        public const string Untappd = "\uf405";

        /// <summary>
        /// fa-upload unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/upload
        /// </summary>
        public const string Upload = "\uf093";

        /// <summary>
        /// fa-usb unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/usb
        /// </summary>
        public const string Usb = "\uf287";

        /// <summary>
        /// fa-usd-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/usd-circle
        /// </summary>
        public const string UsdCircle = "\uf2e8";

        /// <summary>
        /// fa-usd-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/usd-square
        /// </summary>
        public const string UsdSquare = "\uf2e9";

        /// <summary>
        /// fa-user unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user
        /// </summary>
        public const string User = "\uf007";

        /// <summary>
        /// fa-user-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-alt
        /// </summary>
        public const string UserAlt = "\uf406";

        /// <summary>
        /// fa-user-alt-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-alt-slash
        /// </summary>
        public const string UserAltSlash = "\uf4fa";

        /// <summary>
        /// fa-user-astronaut unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-astronaut
        /// </summary>
        public const string UserAstronaut = "\uf4fb";

        /// <summary>
        /// fa-user-chart unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/user-chart
        /// </summary>
        public const string UserChart = "\uf6a3";

        /// <summary>
        /// fa-user-check unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-check
        /// </summary>
        public const string UserCheck = "\uf4fc";

        /// <summary>
        /// fa-user-circle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-circle
        /// </summary>
        public const string UserCircle = "\uf2bd";

        /// <summary>
        /// fa-user-clock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-clock
        /// </summary>
        public const string UserClock = "\uf4fd";

        /// <summary>
        /// fa-user-cog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-cog
        /// </summary>
        public const string UserCog = "\uf4fe";

        /// <summary>
        /// fa-user-crown unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/user-crown
        /// </summary>
        public const string UserCrown = "\uf6a4";

        /// <summary>
        /// fa-user-edit unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-edit
        /// </summary>
        public const string UserEdit = "\uf4ff";

        /// <summary>
        /// fa-user-friends unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-friends
        /// </summary>
        public const string UserFriends = "\uf500";

        /// <summary>
        /// fa-user-graduate unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-graduate
        /// </summary>
        public const string UserGraduate = "\uf501";

        /// <summary>
        /// fa-user-injured unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-injured
        /// </summary>
        public const string UserInjured = "\uf728";

        /// <summary>
        /// fa-user-lock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-lock
        /// </summary>
        public const string UserLock = "\uf502";

        /// <summary>
        /// fa-user-md unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-md
        /// </summary>
        public const string UserMd = "\uf0f0";

        /// <summary>
        /// fa-user-minus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-minus
        /// </summary>
        public const string UserMinus = "\uf503";

        /// <summary>
        /// fa-user-ninja unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-ninja
        /// </summary>
        public const string UserNinja = "\uf504";

        /// <summary>
        /// fa-user-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-plus
        /// </summary>
        public const string UserPlus = "\uf234";

        /// <summary>
        /// fa-user-secret unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-secret
        /// </summary>
        public const string UserSecret = "\uf21b";

        /// <summary>
        /// fa-user-shield unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-shield
        /// </summary>
        public const string UserShield = "\uf505";

        /// <summary>
        /// fa-user-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-slash
        /// </summary>
        public const string UserSlash = "\uf506";

        /// <summary>
        /// fa-user-tag unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-tag
        /// </summary>
        public const string UserTag = "\uf507";

        /// <summary>
        /// fa-user-tie unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-tie
        /// </summary>
        public const string UserTie = "\uf508";

        /// <summary>
        /// fa-user-times unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/user-times
        /// </summary>
        public const string UserTimes = "\uf235";

        /// <summary>
        /// fa-users unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/users
        /// </summary>
        public const string Users = "\uf0c0";

        /// <summary>
        /// fa-users-class unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/users-class
        /// </summary>
        public const string UsersClass = "\uf63d";

        /// <summary>
        /// fa-users-cog unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/users-cog
        /// </summary>
        public const string UsersCog = "\uf509";

        /// <summary>
        /// fa-users-crown unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/users-crown
        /// </summary>
        public const string UsersCrown = "\uf6a5";

        /// <summary>
        /// fa-ussunnah unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/ussunnah
        /// </summary>
        public const string Ussunnah = "\uf407";

        /// <summary>
        /// fa-utensil-fork unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/utensil-fork
        /// </summary>
        public const string UtensilFork = "\uf2e3";

        /// <summary>
        /// fa-utensil-knife unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/utensil-knife
        /// </summary>
        public const string UtensilKnife = "\uf2e4";

        /// <summary>
        /// fa-utensil-spoon unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/utensil-spoon
        /// </summary>
        public const string UtensilSpoon = "\uf2e5";

        /// <summary>
        /// fa-utensils unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/utensils
        /// </summary>
        public const string Utensils = "\uf2e7";

        /// <summary>
        /// fa-utensils-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/utensils-alt
        /// </summary>
        public const string UtensilsAlt = "\uf2e6";

        /// <summary>
        /// fa-vaadin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vaadin
        /// </summary>
        public const string Vaadin = "\uf408";

        /// <summary>
        /// fa-value-absolute unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/value-absolute
        /// </summary>
        public const string ValueAbsolute = "\uf6a6";

        /// <summary>
        /// fa-vector-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vector-square
        /// </summary>
        public const string VectorSquare = "\uf5cb";

        /// <summary>
        /// fa-venus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/venus
        /// </summary>
        public const string Venus = "\uf221";

        /// <summary>
        /// fa-venus-double unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/venus-double
        /// </summary>
        public const string VenusDouble = "\uf226";

        /// <summary>
        /// fa-venus-mars unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/venus-mars
        /// </summary>
        public const string VenusMars = "\uf228";

        /// <summary>
        /// fa-viacoin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/viacoin
        /// </summary>
        public const string Viacoin = "\uf237";

        /// <summary>
        /// fa-viadeo unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/viadeo
        /// </summary>
        public const string Viadeo = "\uf2a9";

        /// <summary>
        /// fa-viadeo-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/viadeo-square
        /// </summary>
        public const string ViadeoSquare = "\uf2aa";

        /// <summary>
        /// fa-vial unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vial
        /// </summary>
        public const string Vial = "\uf492";

        /// <summary>
        /// fa-vials unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vials
        /// </summary>
        public const string Vials = "\uf493";

        /// <summary>
        /// fa-viber unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/viber
        /// </summary>
        public const string Viber = "\uf409";

        /// <summary>
        /// fa-video unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/video
        /// </summary>
        public const string Video = "\uf03d";

        /// <summary>
        /// fa-video-plus unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/video-plus
        /// </summary>
        public const string VideoPlus = "\uf4e1";

        /// <summary>
        /// fa-video-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/video-slash
        /// </summary>
        public const string VideoSlash = "\uf4e2";

        /// <summary>
        /// fa-vihara unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vihara
        /// </summary>
        public const string Vihara = "\uf6a7";

        /// <summary>
        /// fa-vimeo unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vimeo
        /// </summary>
        public const string Vimeo = "\uf40a";

        /// <summary>
        /// fa-vimeo-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vimeo-square
        /// </summary>
        public const string VimeoSquare = "\uf194";

        /// <summary>
        /// fa-vimeo-v unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vimeo-v
        /// </summary>
        public const string VimeoV = "\uf27d";

        /// <summary>
        /// fa-vine unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vine
        /// </summary>
        public const string Vine = "\uf1ca";

        /// <summary>
        /// fa-vk unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vk
        /// </summary>
        public const string Vk = "\uf189";

        /// <summary>
        /// fa-vnv unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vnv
        /// </summary>
        public const string Vnv = "\uf40b";

        /// <summary>
        /// fa-volcano unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/volcano
        /// </summary>
        public const string Volcano = "\uf770";

        /// <summary>
        /// fa-volleyball-ball unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/volleyball-ball
        /// </summary>
        public const string VolleyballBall = "\uf45f";

        /// <summary>
        /// fa-volume unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/volume
        /// </summary>
        public const string Volume = "\uf6a8";

        /// <summary>
        /// fa-volume-down unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/volume-down
        /// </summary>
        public const string VolumeDown = "\uf027";

        /// <summary>
        /// fa-volume-mute unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/volume-mute
        /// </summary>
        public const string VolumeMute = "\uf6a9";

        /// <summary>
        /// fa-volume-off unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/volume-off
        /// </summary>
        public const string VolumeOff = "\uf026";

        /// <summary>
        /// fa-volume-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/volume-slash
        /// </summary>
        public const string VolumeSlash = "\uf2e2";

        /// <summary>
        /// fa-volume-up unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/volume-up
        /// </summary>
        public const string VolumeUp = "\uf028";

        /// <summary>
        /// fa-vote-nay unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/vote-nay
        /// </summary>
        public const string VoteNay = "\uf771";

        /// <summary>
        /// fa-vote-yea unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vote-yea
        /// </summary>
        public const string VoteYea = "\uf772";

        /// <summary>
        /// fa-vr-cardboard unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/vr-cardboard
        /// </summary>
        public const string VrCardboard = "\uf729";

        /// <summary>
        /// fa-vuejs unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/vuejs
        /// </summary>
        public const string Vuejs = "\uf41f";

        /// <summary>
        /// fa-walking unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/walking
        /// </summary>
        public const string Walking = "\uf554";

        /// <summary>
        /// fa-wallet unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wallet
        /// </summary>
        public const string Wallet = "\uf555";

        /// <summary>
        /// fa-wand unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wand
        /// </summary>
        public const string Wand = "\uf72a";

        /// <summary>
        /// fa-wand-magic unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wand-magic
        /// </summary>
        public const string WandMagic = "\uf72b";

        /// <summary>
        /// fa-warehouse unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/warehouse
        /// </summary>
        public const string Warehouse = "\uf494";

        /// <summary>
        /// fa-warehouse-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/warehouse-alt
        /// </summary>
        public const string WarehouseAlt = "\uf495";

        /// <summary>
        /// fa-watch unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/watch
        /// </summary>
        public const string Watch = "\uf2e1";

        /// <summary>
        /// fa-watch-fitness unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/watch-fitness
        /// </summary>
        public const string WatchFitness = "\uf63e";

        /// <summary>
        /// fa-water unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/water
        /// </summary>
        public const string Water = "\uf773";

        /// <summary>
        /// fa-water-lower unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/water-lower
        /// </summary>
        public const string WaterLower = "\uf774";

        /// <summary>
        /// fa-water-rise unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/water-rise
        /// </summary>
        public const string WaterRise = "\uf775";

        /// <summary>
        /// fa-weebly unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/weebly
        /// </summary>
        public const string Weebly = "\uf5cc";

        /// <summary>
        /// fa-weibo unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/weibo
        /// </summary>
        public const string Weibo = "\uf18a";

        /// <summary>
        /// fa-weight unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/weight
        /// </summary>
        public const string Weight = "\uf496";

        /// <summary>
        /// fa-weight-hanging unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/weight-hanging
        /// </summary>
        public const string WeightHanging = "\uf5cd";

        /// <summary>
        /// fa-weixin unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/weixin
        /// </summary>
        public const string Weixin = "\uf1d7";

        /// <summary>
        /// fa-whale unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/whale
        /// </summary>
        public const string Whale = "\uf72c";

        /// <summary>
        /// fa-whatsapp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/whatsapp
        /// </summary>
        public const string Whatsapp = "\uf232";

        /// <summary>
        /// fa-whatsapp-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/whatsapp-square
        /// </summary>
        public const string WhatsappSquare = "\uf40c";

        /// <summary>
        /// fa-wheat unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wheat
        /// </summary>
        public const string Wheat = "\uf72d";

        /// <summary>
        /// fa-wheelchair unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wheelchair
        /// </summary>
        public const string Wheelchair = "\uf193";

        /// <summary>
        /// fa-whistle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/whistle
        /// </summary>
        public const string Whistle = "\uf460";

        /// <summary>
        /// fa-whmcs unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/whmcs
        /// </summary>
        public const string Whmcs = "\uf40d";

        /// <summary>
        /// fa-wifi unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wifi
        /// </summary>
        public const string Wifi = "\uf1eb";

        /// <summary>
        /// fa-wifi-1 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wifi-1
        /// </summary>
        public const string Wifi1 = "\uf6aa";

        /// <summary>
        /// fa-wifi-2 unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wifi-2
        /// </summary>
        public const string Wifi2 = "\uf6ab";

        /// <summary>
        /// fa-wifi-slash unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wifi-slash
        /// </summary>
        public const string WifiSlash = "\uf6ac";

        /// <summary>
        /// fa-wikipedia-w unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wikipedia-w
        /// </summary>
        public const string WikipediaW = "\uf266";

        /// <summary>
        /// fa-wind unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wind
        /// </summary>
        public const string Wind = "\uf72e";

        /// <summary>
        /// fa-wind-warning unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/wind-warning
        /// </summary>
        public const string WindWarning = "\uf776";

        /// <summary>
        /// fa-window unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/window
        /// </summary>
        public const string Window = "\uf40e";

        /// <summary>
        /// fa-window-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/window-alt
        /// </summary>
        public const string WindowAlt = "\uf40f";

        /// <summary>
        /// fa-window-close unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/window-close
        /// </summary>
        public const string WindowClose = "\uf410";

        /// <summary>
        /// fa-window-maximize unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/window-maximize
        /// </summary>
        public const string WindowMaximize = "\uf2d0";

        /// <summary>
        /// fa-window-minimize unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/window-minimize
        /// </summary>
        public const string WindowMinimize = "\uf2d1";

        /// <summary>
        /// fa-window-restore unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular, Solid
        /// <para/>
        /// See https://fontawesome.com/icons/window-restore
        /// </summary>
        public const string WindowRestore = "\uf2d2";

        /// <summary>
        /// fa-windows unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/windows
        /// </summary>
        public const string Windows = "\uf17a";

        /// <summary>
        /// fa-windsock unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid (Pro)
        /// <para/>
        /// See https://fontawesome.com/icons/windsock
        /// </summary>
        public const string Windsock = "\uf777";

        /// <summary>
        /// fa-wine-bottle unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wine-bottle
        /// </summary>
        public const string WineBottle = "\uf72f";

        /// <summary>
        /// fa-wine-glass unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wine-glass
        /// </summary>
        public const string WineGlass = "\uf4e3";

        /// <summary>
        /// fa-wine-glass-alt unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wine-glass-alt
        /// </summary>
        public const string WineGlassAlt = "\uf5ce";

        /// <summary>
        /// fa-wix unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wix
        /// </summary>
        public const string Wix = "\uf5cf";

        /// <summary>
        /// fa-wizards-of-the-coast unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wizards-of-the-coast
        /// </summary>
        public const string WizardsOfTheCoast = "\uf730";

        /// <summary>
        /// fa-wolf-pack-battalion unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wolf-pack-battalion
        /// </summary>
        public const string WolfPackBattalion = "\uf514";

        /// <summary>
        /// fa-won-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/won-sign
        /// </summary>
        public const string WonSign = "\uf159";

        /// <summary>
        /// fa-wordpress unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wordpress
        /// </summary>
        public const string Wordpress = "\uf19a";

        /// <summary>
        /// fa-wordpress-simple unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wordpress-simple
        /// </summary>
        public const string WordpressSimple = "\uf411";

        /// <summary>
        /// fa-wpbeginner unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wpbeginner
        /// </summary>
        public const string Wpbeginner = "\uf297";

        /// <summary>
        /// fa-wpexplorer unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wpexplorer
        /// </summary>
        public const string Wpexplorer = "\uf2de";

        /// <summary>
        /// fa-wpforms unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wpforms
        /// </summary>
        public const string Wpforms = "\uf298";

        /// <summary>
        /// fa-wpressr unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/wpressr
        /// </summary>
        public const string Wpressr = "\uf3e4";

        /// <summary>
        /// fa-wrench unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/wrench
        /// </summary>
        public const string Wrench = "\uf0ad";

        /// <summary>
        /// fa-x-ray unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/x-ray
        /// </summary>
        public const string XRay = "\uf497";

        /// <summary>
        /// fa-xbox unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/xbox
        /// </summary>
        public const string Xbox = "\uf412";

        /// <summary>
        /// fa-xing unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/xing
        /// </summary>
        public const string Xing = "\uf168";

        /// <summary>
        /// fa-xing-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/xing-square
        /// </summary>
        public const string XingSquare = "\uf169";

        /// <summary>
        /// fa-y-combinator unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/y-combinator
        /// </summary>
        public const string YCombinator = "\uf23b";

        /// <summary>
        /// fa-yahoo unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/yahoo
        /// </summary>
        public const string Yahoo = "\uf19e";

        /// <summary>
        /// fa-yandex unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/yandex
        /// </summary>
        public const string Yandex = "\uf413";

        /// <summary>
        /// fa-yandex-international unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/yandex-international
        /// </summary>
        public const string YandexInternational = "\uf414";

        /// <summary>
        /// fa-yelp unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/yelp
        /// </summary>
        public const string Yelp = "\uf1e9";

        /// <summary>
        /// fa-yen-sign unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/yen-sign
        /// </summary>
        public const string YenSign = "\uf157";

        /// <summary>
        /// fa-yin-yang unicode value.
        /// <para/>
        /// This icon supports the following styles: Light (Pro), Regular (Pro), Solid
        /// <para/>
        /// See https://fontawesome.com/icons/yin-yang
        /// </summary>
        public const string YinYang = "\uf6ad";

        /// <summary>
        /// fa-yoast unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/yoast
        /// </summary>
        public const string Yoast = "\uf2b1";

        /// <summary>
        /// fa-youtube unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/youtube
        /// </summary>
        public const string Youtube = "\uf167";

        /// <summary>
        /// fa-youtube-square unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/youtube-square
        /// </summary>
        public const string YoutubeSquare = "\uf431";

        /// <summary>
        /// fa-zhihu unicode value.
        /// <para/>
        /// This icon supports the following styles: Brands
        /// <para/>
        /// See https://fontawesome.com/icons/zhihu
        /// </summary>
        public const string Zhihu = "\uf63f";
    }
}
