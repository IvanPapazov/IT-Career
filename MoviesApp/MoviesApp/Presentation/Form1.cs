﻿using System;
using System.Windows.Forms;
using MoviesApp.Data.Model;
using System.Drawing;
using MoviesApp.Presentation;
using System.IO;
using System.Collections.Generic;
using MoviesApp.Business;

namespace MoviesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            EnsureDateBaseIsCreated();
            pictureBox2.AllowDrop = true;
        }
        MovieBusiness bc;
        string description = "";
        private void FullDatabase()
        {
            List<string> descriptions = new List<string>();
            descriptions.Add("15 април 1912 година. Трагичната гибел на най-големия и луксозен за времето си кораб" +
                " с 2 223 пътника на борда си обикаля света и хвърля в покруса милиони хора." +
                " За по-малко от три часа хиляди пасажери са погълнати от ледените води на океана." +
                " Фаталният слъсък на презокеанския лайнер \"Титаник\" с гигантски айсберг е една от най-трагичните катастрофи в историята на мореплаването," +
                " но ведно с това и символ на човешкото страдание."); // Титаник
            descriptions.Add("Филмът представя непознат свят през погледа на прикования към инвалидна количка," +
                " бивш морски пехотинец Джейк Съли. Въпреки болното си тяло, Джейк продължава да е войн по душа." +
                " Той е вербуван за далечна мисия, да пътува до отдалечената на светлинни години планета Пандора," +
                " на която корпоративна организация добива рядък минерал, ключ към разрешаването на енергийната криза на Земята." +
                " Тъй като атмосферата на Пандора е силно токсична, е създадена Програма АВАТАР," +
                " чрез която човешкото съзнание се прикрепя към управлявано от разстояние биологично тяло, способно да живее в смъртоносната среда." +
                " „Аватарите” са генетично създадени хибриди на човешка  ДНК и ДНК на жителите на Пандора – Нави."); // Аватар
            descriptions.Add("Разказва се за хуманоиден робот – Терминатор, който е транспортиран назад във времето от 2029 г. в 1984 г." +
                " (датата е 12 май), за да убие жена на име Сара Конър. В същото време назад във времето е пратен и мъж, Кайл Рийс," +
                " който да предпази Конър от киборга. Темите, засегнати във филма, включват пътуване във времето, причинно-следствен цикъл и изкуствен интелект."); // Терминаторът
            descriptions.Add("Какво може да се обърка след едноседмично пътуване с дядо?" +
                " Ами...всичко! Точно преди сватбата си, Джейсън (Зак Ефрон)" +
                " е подлъган да откара дядо си - бивш генерал - в слънчева Флорида," +
                " за да посрещне там \"по мъжки\" началото на пролетта.На него му остава" +
                " само седмица до сватбата с властната дъщеря на шефа му, от когото зависи" +
                " да се издигне до съдружник. Но подтикнат от дядо си - цапнатия в устата Дик (Робърт Де Ниро)," +
                " Джейсън се оказва на път към Дейтона Бийч..."); // Ох на Дядо 
            descriptions.Add("Бела Суон (Кристън Стюарт) никога не е приличала на момичетата от нейното училище във Финикс, Аризона." +
                " Когато майка й Рене (Сара Кларк) се омъжва за втори път и се премества със съпруга си във Флорида, Бела решава да живее с баща си Чарли (Били Бърк)" +
                " в малкото дъждовно градче Форкс. Не очаква нещо да се промени, докато не среща тайнствения и невероятно красив Едуард Кълън (Робърт Патинсън). " +
                "Той е различен от всички, които е срещала – интелигентен и духовит. Бела и Едуард се впускат в страстна и различна от общоприетите норми връзка." +
                " Едуард може да бяга по- бързо от всеки леорпард, може да спре кола с голи ръце и не е се е променил от 1918 насам. И най – важното - той е вампир..."); // Здрач
            descriptions.Add("От десетилетия, хората от Дагърхорн подържат нелеко примирие с върколака, като му принасят в жертва по едно животно, всяко новолуние," +
                " когато звярът излиза за плячка. Но когато настъпва кървавочервената луна, той отнема човешки живот. Жертвата е по-голямата сестра на Валъри, която току-що е разбрала," +
                " че родителите й са уредили брака й с Хенри, потомък на една от най-богатите фамилии в селото. Валъри обаче, желае единствено бедния дървар Питър," +
                " когото е обичала през целия си живот. За да предотвратят нежеланата раздяла, влюбените планират бягство, но вълкът променя нещата по ужасяващ начин."); // Червената шапчица
            descriptions.Add("Когато се появява неочакван враг, заплашващ глобалната сигурност, Ник Фюри, директор на международната мироопазваща агенция," +
                " известна под името ЩИТ изпитва остра нужда от екип, който да спаси света от надвисналата катастрофа."); // Отмъстителите
            descriptions.Add("Повече от 200 години след гибелта на лейтенант Рипли. Военни учения, в опит за създаване на съвършеното оръжие, възвръщат главната героиня към живот, като я клонират." +
                " Кръвта на Рипли носи в себе си образец ДНК от „Пришълеца“, и военните искат тя да роди дете – наполовина човек, наполовина „Пришълец“."); // Пришълецът
            descriptions.Add("В центъра на сюжета в „Синята лагуна: Пробуждане / Blue Lagoon: The Awakening (2012)“, са двама тийнейджъри Ема и Дийн, които попадат на необитаем остров в Карибско море." +
                " По време на разходка с корабче, Ема пада зад борда, а само Дийн вижда и скоча след нея в морето. Седмици минават и младите хора се влюбват, научават много един за друг, както и за себе си."); // Синята Лагуна
            descriptions.Add("Това е Анабел – кукла закупена през 1970 г. от младо момиче. След като привидно обикновената играчка попаднала в дома на девойката, започнали да се случват странни неща – оставяне на бележки с надпис „Помощ“ из цялата къща." +
                " Приятел на семейството дори разказвал, че бил нападнат от куклата, когато им е бил на гости."); // Анабел
            descriptions.Add("Действието на филма е ситуирано в щата Роуд Айлънд, а сюжета проследява двойката Едуард и Лорейн Уорън, които са едни от най-известните и уважавани изследователи на паранормалните явления в Съединените щати." +
                " Най-новата им задача ги изпраща в отдалечена фермерска къща в която живее седемчленното семейство на Керълин и Роджър Перон. Керълин е убедена," +
                " че къщата е обладана от призрачни същества и твърденията й се превръщат в идеалната възможност за Едуард и Лорейн да изпробват всичките си техники и знания за връзка с отвъдното." +
                " Но скоро става ясно, че демоничните сили са много по-могъщи от очакваното."); // Заклинанието
            descriptions.Add("След като група тийнейджъри от американския Среден Запад изчезват мистериозно," +
                " местните хора приписват деянието на Кухия човек – страховито същество от популярна градска легенда."); // Кухият човек
            descriptions.Add("Честита смърт използва сюжетния похват „времева примка“ (популяризиран с голям успех от хита Омагьосън ден), за да разкаже за разхайтената колежанка Трий Гелбман (Джесика Рот, Ла Ла Ленд), която е принудена да преживява отново и отново деня на своята смърт, докато не разкрие самоличността на собствения си убиец.Докато бавно разплита мистерията около гибелта си, Трий вижда хората около себе си в непозната светлина и открива истини, които с лекота е подминавала в ежедневието си на купонджийка." +
                " За да успее да избяга от капана на повтарящия се ден, тя трябва да преоткрие света и най-вече себе си."); // Честита смърт 
            descriptions.Add("Годината е 1905. Томас Ричардсън се отправя към отдалечен остров, за да спаси сестра си, отвлечена от тайна религиозна общност. Там той се сблъсква с тайни и лъжи, " +
                "на които е основано това общество. Неговите членове, обаче горчиво ще съжаляват, че са обезпокоили Ричардсън."); // Апостол
            descriptions.Add("Дълбоко в сърцето на джакартските гета се извисява недостъпен дори за най-дръзките и безразсъдни ченгета блок," +
                " който служи за сигурно убежище на най-опасните убийци и гангстери. Под прикритието на мрака и необезпокояваната тишина на най-ранна утрин," +
                " елитен полицейски отряд се промъква в сградата, за да залови прословутия наркотрафикант, който я управлява."); // Щурмът
            descriptions.Add("Джо Гарднър е учител по музика в средно училище, който има дългогодишна мечта да свири джаз музика на сцена." +
                " Един ден той най-накрая получава този шанс, след като впечатлява група джаз."); // За душата
            descriptions.Add("Съли и неговия асистент Майк работят в компанията „Таласъми ООД” – най-голямата електроценрала в техния град, която генерира ток от писъците на изплашените деца. Таласъмите вярват, че децата са опасни създания и когато едно малко момиченце случайно прониква в техния свят," +
                " той се преобръща с главата надолу. Съли и Майк трябва да направят всичко възможно, за да я върнат у дома."); //Таласъми ООД
            descriptions.Add("Филмът ни отвежда на един остров, населен изцяло от щастливи, нелетящи птици - или почти изцяло. Изнервеният Ред (озвучен на български от Слави Трифонов), бързакът Чък (Иво Сиромахов) и избухливият Бомб (Стоян Цветков) така и не успяват да се впишат в този рай." +
                " Но когато на острова пристигат загадъчни зелени прасенца, точно тези аутсайдери ще предвидят какво са замислили нашествениците."); //Angry Birds: Филмът
            descriptions.Add("В \"Аз, проклетникът 2\" Гру е оставил карерата си на супер престъпник и се е посветил на отглеждането на Марго, Едит и Агнес. Сега той, д-р Нефарио и жълтите слуги разполагат със свободно време, което трябва да запълнят." +
                " Едва свикнал с ролята си на семеен човек от предградията, натоварен с нелеката задача да се грижи за три малки момиченца, Гру се сблъсква с хипер секретна организация, която се бори със злото по света." +
                " В неговите и ръцете на новата му партньорка Луси Уайлд е отговорността да се разкрие кой стои зад едно от най-големите престъпление и злодеят да бъде наказан." +
                " В крайна сметка именно бившият най-голям злодей е изправен пред предизвикателството да залови своя заместник."); //  Аз, проклетникът 2
            descriptions.Add("Индиана Джоунс попада в Индия заедно със спътниците си Уили Скот (Кейт Кепшоу) и Малчо (Джонатан Ке Куан)." +
                " Тримата се озовават в село, сполетяно от голямо нещастие — група сектанти, кланящи се на богинята Кали," +
                " са отвлекли децата им и са откраднали свещен камък, който е носел плодородие. Д-р Джоунс, Уили и Малчо предприемат пътуване към близкия храм," +
                " за да спасят децата и върнат камъка в селото. След като отиват в дворгеца Панкот, махараджата(който е дете) ги посреща добре," +
                " нахранва ги и им осигурява спални. Когато Инди отива в стаята си, заедно с Малчо го напада тхуг. Инди се опитва да го убие и накрая успява да го обеси." +
                " След това той отива в спалнята на Уили, където след като натиска една статуя се отваря таен проход към залата на жертвоприношенията." +
                " Преди това отиват в нещо като гробница, пълна с гадни и гнусни буболечки. След като тхугите извършват ритуалите и тръгват," +
                " Джоунс слиза долу и взема свещените камъни на Шанхара(почитан индуитски жрец), поставени в устата на Кали. "); // Индиана Джоунс
            descriptions.Add("Хобитът е също книга по едноименният автор Дж. Р. Р. Толкин и ще бъде пресъздадена от режисьора Питър Джаксън в три части." +
                " Първата част ни разкрива началото на историята и представяне на цялостната идея на филма. С нежелание хобита, Билбо Бегинс, има за цел да стигне Самотната планина с енергична група джуджета," +
                " за да си възстановят планински дом – и златото в нея – от дракона Смог. Историята се развива преди всеизвестната трилогията за пръстена."); // Хобит: Неочаквано пътешествие
            descriptions.Add("Питър Джаксън съживява тази фанатзия в удивително филмово приключение. " +
                "То представя незабравим герой - хобитът Фродо Багинс - въвлечен във война с митични мащаби в Средната земя: свят, пълен с вълшебство и магични умения." +
                "Но преди всичко филмът е апотеоз на преданото приятелство и личната смелост, които биха могли да надмогнат дори и най - разрушителните сили на мрака.! "); // Властелинът на пръстените: Задругата на пръстена
            descriptions.Add("Пол Уокър (“Дворец на илюзиите”) е в ролята на млад полицай под прикритие, който влиза в автомобилния екип на Вин Дизел (“Пълен мрак”), за да разследва серия от големи обири." +
                " Но когато някои от бандата започват да се съмняват в него, атмосферата се нажежава и ченгето бързо трябва да решава докъде се простира неговата лоялност…" +
                " Затегнете коланите и се впуснете в предизвикателното препускане с младия екип, който включва още Мишел Родригес и Джордана Брустър (“Факултетът”)." +
                " \"Бързи и яростни\" е замайващо екшън приключение… с високи скорости и горещи страсти. "); // Бързи и яростни
            descriptions.Add("Надпреварата вече не е само на пътя – в някои от каскадите автомобилите буквално летят след динамични превъртания," +
                " а в част от сцените се включват самолети и хеликоптери. На голям екран ще се появи и една от най-впечатляващите „атракции“ в продукцията – танк," +
                " разполагащ с достатъчно голям капацитет, за да бъде равностоен участник в уличната надпревара. За да бъде ефективен противник в тази неравна битка," +
                " отборът на Торето (Вин Дизел) ще използва всичките си умения и ще покаже най-доброто по отношение на каскади, въоръжена борба и физически схватки."); // Бързи и яростни 6
            descriptions.Add("Група десетгодишни деца отстояват независимостта си в училище, на улицата и вкъщи." +
                " Начините им да се противопоставят на възрастните и да преодолеят липсата на разбиране са толкова изобретателни," +
                " че те в края на краищата успяват да направят за посмешище родителите, учителите си и своите съседи. След много перипетии, успехи и неуспехи," +
                " и благодарение на детската солидарност, те успяват да отвоюват обратно футболната си топка, паднала в минаващ камион..."); // Таралежите се раждат без бодли
            descriptions.Add("Малкият Митко – Миташки (в ролята Веселин Прахов) е дете на разведени родители, живее с майка си, вечно заета със служебни събрания," +
                " и по цял ден стои сам вкъщи. Мечтае само за едно нещо — да си има куче — истинско, не плюшена играчка. Заедно с двама негови приятели," +
                " Андро (Мартин Стоянов) и Стефан (Емил Димитров) купуват от един крадец (Павел Поппандов) кучето Рошко за три лева и осемдесет стотинки и шест трамвайни билета." +
                " Тъй като Рошко е общо притежание, се редуват да го гледат и то така че родителите им да не разберат. "); // Куче в чекмедже
            descriptions.Add("1668 г. Османската империя е завладяла Югоизточна Европа, но свещената война за окончателното утвърждаване на исляма продължава." +
                " В Родопите е настанен военен корпус от еничари, предвождан от Караибрахим (Йосиф Сърчаджиев). Заедно с него пътува и Венецианеца (Валтер Тоски)," +
                " който вече е променил религията си. Местният владетел Сюлейман ага (Васил Михайлов) е убеден, че вярата не трябва да се променя по насилствен начин и е наказан със смърт за това." +
                " Сред хората, които трябва да се помохамеданчат, Караибрахим открива баща си (Константин Коцев), брат си Горан (Стойко Пеев)," +
                " сестра си Елица (Калина Стефанова) и най-близкия си приятел Манол (Иван Кръстев). Това не го разколебава да наложи исляма по най-жесток начин." +
                " Той пуска поп Алигорко (Руси Чанев), който е осъзнал, че единственият начин българите да оцелеят и запазят езика и обичаите си, е да пожертват вярата си. "); // Време разделно
            descriptions.Add("България от 20-те години на XX век. Пурко (Тодор Колев) е беден селски музикант, който непрекъснато измисля нови и нови начини да надхитря живота и да изхранва многолюдното си семейство." +
                " Преминавайки през редица смешни и тъжни приключения в борбата с немотията, един хубав ден той докосва мечтата си – превръща се в добре облечен градски господин." +
                " Дали обаче новата му самоличност ще пасне на свободната душа на музиканта? Илюзията рухва, но Пурко намира кураж отново да надуе своя кларинет. "); // Господин за един ден
            descriptions.Add("1945 г. Бойци от Първа българска армия водят тежки боеве за освобождаването на Унгария от хитлеристите." +
                " Към фронтовата линия пътуват трима войници от запаса - Иван, Спиро и Пейо. От цялото им поведение и външен вид личи, че са съвсем неподготвени за предстоящите битки." +
                " Постепенно тримата верни другари стигат до трагичния миг, който ги променя изцяло."); // Тримата от запаса
            descriptions.Add("В миналото, когато се развива действието на филма, краденето на моми е занаят, обичай и не се наказва от закона. Елица – млада, красива," +
                " трудолюбива и свободолюбива девойка бива открадната от Банко и неговите съдружници. Тя прави няколко неуспешни опита да избяга, но след като не успява," +
                " се моли на Банко поне той да я вземе за жена, а да не я дава на невзрачния младоженец, за когото я е откраднал. Банко обаче държи на мъжката си дума." +
                " По-късно обаче той разбира, че се е влюбил в нея и в края на филма бива убит, отстоявайки правото си да е с нея. "); // Мъжки времена



            // directors
            List<Director> directors = new List<Director>();
            directors.Add(new Director("Джеймс", "Камерън")); // 1 - Титаник, Аватар, Терминаторът
            directors.Add(new Director("Дан", "Мейзър")); // 2 - Ох на Дядо
            directors.Add(new Director("Катрин", "Хардуик")); // 3 - Здрач, Червената шапчица
            directors.Add(new Director("Джос", "Уедън")); // 4 - Отмъстителите, Пришълецът
            directors.Add(new Director("Джейк", "Нюсом")); // 5 - Синята Лагуна
            directors.Add(new Director("Джон", "Р. Леонети")); // 6 - Анабел, Заклинанието
            directors.Add(new Director("Дейвид", "Прайър")); // 7 - Кухият човек
            directors.Add(new Director("Кристофър", "Ландън")); // 8 - Честита смърт
            directors.Add(new Director("Гарет", "Еванс")); // 9 - Апостол, Щурмът
            directors.Add(new Director("Пийт", "Доктър")); // 10 - За душата, Таласъми ООД
            directors.Add(new Director("Клай ", "Кайтис")); // 11 -  Angry Birds: Филмът
            directors.Add(new Director("Пиер", "Кофин")); // 12 -  Аз, проклетникът 2
            directors.Add(new Director("Джеймс", "Манголд")); // 13 - Индиана Джоунс
            directors.Add(new Director("Питър", "Джаксън")); // 14 - Хобит: Неочаквано пътешествие, Властелинът на пръстените: Задругата на пръстена
            directors.Add(new Director("Роб", "Коен")); // 15 - Бързи и яростни
            directors.Add(new Director("Джъстин", "Лин")); // 16 - Бързи и яростни 6
            directors.Add(new Director("Димитър", "Петров")); // 17 - Таралежите се раждат без бодли, Куче в чекмедже
            directors.Add(new Director("Людмил", "Стайков")); // 18 - Време разделно
            directors.Add(new Director("Николай", "Волев")); // 19 - Господин за един ден  
            directors.Add(new Director("Зако", "Хеския")); // 20 - Тримата от запаса
            directors.Add(new Director("Едуард", "Захариев")); // 21 - Мъжки времена
            foreach (var d in directors)
            {
                bc.Add(d);
            }

            List<Genre> genres = new List<Genre>();
            genres.Add(new Genre("Екшън"));//1
            genres.Add(new Genre("Приключенски"));//2
            genres.Add(new Genre("Комедия"));//3
            genres.Add(new Genre("Криминален"));//4
            genres.Add(new Genre("Фентъзи"));//5
            genres.Add(new Genre("Научна фантастика"));//6
            genres.Add(new Genre("Исторически"));//7
            genres.Add(new Genre("Ужаси"));//8
            genres.Add(new Genre("Романтичен"));//9
            genres.Add(new Genre("Трилър"));//10
            genres.Add(new Genre("Анимация"));//11
            genres.Add(new Genre("Драма"));//12
            foreach (var g in genres)
            {
                bc.Add(g);
            }

            List<int> genresId;
            List<Movie> movies = new List<Movie>();

            description = descriptions[0];
            movies.Add(new Movie("Титаник", 1997, 210, "САЩ", 1, description));
            List<string> titanicActors = new List<string>() { "Леонардо ДиКаприо мъж", "Кейт Уинслет жена", "Били Зейн мъж", "Франсис Фишър жена" };

            description = descriptions[1];
            movies.Add(new Movie("Аватар", 2009, 162, "САЩ", 1, description));
            List<string> avatarActors = new List<string>() { "Сам Уортингтън мъж", "Джовани Рибизи мъж", "Сигорни Уивър жена" };

            description = descriptions[2];
            movies.Add(new Movie("Терминаторът", 1984, 107, "САЩ", 1, description));
            List<string> terminatorActors = new List<string>() { "Арнолд Шварценегер мъж", "Майкъл Бийн мъж", "Линда Хамилтън жена" };

            description = descriptions[3];
            movies.Add(new Movie("Ох, на дядо!", 2016, 102, "САЩ", 2, description));
            List<string> OhGrandDadActors = new List<string>() { "Робърт ДеНиро мъж", "Зак Ефрон мъж", "Зоуи Дойч жена", "Обри Плаза жена", "Дермът Мълроуни мъж" };

            description = descriptions[4];
            movies.Add(new Movie("Здрач", 2008, 122, "САЩ", 3, description));
            List<string> duskActors = new List<string>() { "Кристин Стюарт мъж", "Робърт Патинсън мъж", "Били Бърк мъж" };

            description = descriptions[5];
            movies.Add(new Movie("Червената шапчица", 2011, 100, "САЩ", 3, description));
            List<string> redHatActors = new List<string>() { "Аманда Сийфрид жена", "Шайло Фернандес мъж", "Макс Айрънс мъж" };

            description = descriptions[6];
            movies.Add(new Movie("Отмъстителите", 2012, 143, "САЩ", 4, description));
            List<string> avengersActors = new List<string>() { "Крис Хемсуърт мъж", "Крис Евънс мъж", "Коби Смълдерс мъж" };

            description = descriptions[7];
            movies.Add(new Movie("Пришълецът: Завръщането", 2019, 108, "САЩ", 4, description));
            List<string> theAlienActors = new List<string>() { "Сигорни Уийвър жена", "Лилънд Орсър мъж", "Рон Пърлман мъж" };

            description = descriptions[8];
            movies.Add(new Movie("Синята лагуна: Пробуждане", 2012, 85, "САЩ", 5, description));
            List<string> blueLagunaActors = new List<string>() { "Индиана Евънс жена", "Брентън Туейтс мъж", "Денис Ричардс мъж" };

            description = descriptions[9];
            movies.Add(new Movie("Анабел", 2014, 98, "САЩ", 6, description));
            List<string> anabelActors = new List<string>() { "Анабел Уолис жена", "Уорт Хортън мъж", "Алфри Ударт мъж", "Тони Амендола мъж" };

            description = descriptions[10];
            movies.Add(new Movie("Заклинанието", 2013, 112, "САЩ", 6, description));
            List<string> theConjuringActors = new List<string>() { "Вера Фармига жена", "Джои Кинг мъж", "Лили Тейлър жена" };

            description = descriptions[11];
            movies.Add(new Movie("Кухият човек", 2020, 137, "Франция", 7, description));
            List<string> theEmptyManActors = new List<string>() { "Джоел Кортни жена", "Стивън Рут мъж", "Джеймс Бадж Дейл мъж" };

            description = descriptions[12];
            movies.Add(new Movie("Честита смърт", 2017, 96, "САЩ", 8, description));
            List<string> theHappyDeadDayActors = new List<string>() { "Джесика Рот жена", "Израел Брусард мъж", "Руби Модин мъж" };

            description = descriptions[13];
            movies.Add(new Movie("Апостол", 2018, 130, "Великобритания", 9, description));
            List<string> apostleActors = new List<string>() { "Дан Стивънс мъж", "Майкъл Шийн мъж", "Луси Бойнтън жена" };

            description = descriptions[14];
            movies.Add(new Movie("Щурмът", 2011, 101, "Великобритания", 9, description));
            List<string> theAssaultActors = new List<string>() { "Верди Солайман мъж", "Джо Таслим мъж", "Дони Аламсиа жена", "Ианг Дармаван мъж" };

            description = descriptions[15];
            movies.Add(new Movie("За душата", 2020, 100, "САЩ", 10, description));
            List<string> forTheSoulActors = new List<string>() { "Джейми Фокс мъж", "Тина Фей жена", "Греъм Нортън мъж" };

            description = descriptions[16];
            movies.Add(new Movie("Таласъми ООД", 2001, 88, "САЩ", 10, description));
            List<string> monstersOODActors = new List<string>() { "Джон Гудмън мъж", "Били Кристъл мъж", "Стив Бушеми мъж", "Джеймс Кобърн мъж" };

            description = descriptions[17];
            movies.Add(new Movie("Angry Birds: Филмът", 2016, 97, "САЩ", 11, description));
            List<string> angryBirdsActors = new List<string>() { "Джейсън Съдейкис мъж", "Джош Гад мъж" };

            description = descriptions[18];
            movies.Add(new Movie("Аз, проклетникът 2", 2013, 98, "САЩ", 12, description));
            List<string> despicableMeActors = new List<string>() { "Стийв Карел мъж", "Миранда Косгров жена", "Кристен Уиг жена" };

            description = descriptions[19];
            movies.Add(new Movie("Индиана Джоунс", 1981, 127, "САЩ", 13, description));
            List<string> indianaJonesActors = new List<string>() { "Харисън Форд мъж", "Ривър Финикс мъж", "Шон Шатрик Фланъри мъж", "Джордж Хол мъж" };

            description = descriptions[20];
            movies.Add(new Movie("Хобит: Неочаквано пътешествие", 2012, 169, "Нова Зеландия", 14, description));
            List<string> hobbitActors = new List<string>() { "Мартин Фрийман мъж", "Иън Маккелън мъж", "Кейт Бланшет жена" };

            description = descriptions[21];
            movies.Add(new Movie("Властелинът на пръстените: Задругата на пръстена", 2001, 178, "Нова Зеландия", 14, description));
            List<string> lordOfTheRingsActors = new List<string>() { "Хюго Уийвинг мъж", "Илайджа Ууд жена", "Лив Тайлър мъж", "Кристофър Лий мъж", "Йън Маккелън мъж" };

            description = descriptions[22];
            movies.Add(new Movie("Бързи и яростни", 2001, 106, "САЩ", 15, description));
            List<string> fAndFuriousActors = new List<string>() { "Пол Уокър мъж", "Вин Дизел мъж", "Мишел Родригес жена", "Джордана Брустър жена" };

            description = descriptions[23];
            movies.Add(new Movie("Бързи и яростни 6", 2013, 130, "САЩ", 16, description));
            List<string> fAndFurious6Actors = new List<string>() { "Пол Уокър мъж", "Вин Дизел мъж", "Дуейн Джонсън(Скалата) мъж", "Джо Таслим мъж", "Люк Евънс мъж" };

            description = descriptions[24];
            movies.Add(new Movie("Таралежите се раждат без бодли", 1971, 84, "България", 17, description));
            List<string> hedgehogActors = new List<string>() { "Димитър Цонев мъж", "Ивайло Джамбазов мъж", "Андрей Слабаков мъж", "Васил Стойчев мъж" };

            description = descriptions[25];
            movies.Add(new Movie("Куче в чекмедже", 1981, 86, "България", 17, description));
            List<string> dogDrawerActors = new List<string>() { "Веселин Прахов мъж", "Емил Димитров мъж", "Людмила Филипова жена", "Стефан Илиев мъж", "Ружа Делчева жена" };

            description = descriptions[26];
            movies.Add(new Movie("Време разделно", 1988, 160, "България", 18, description));
            List<string> timeDiffActors = new List<string>() { "Йосиф Сърчаджиев мъж", "Руси Чанев мъж", "Иван Кръстев мъж", "Аня Пенчева жена" };

            description = descriptions[27];
            movies.Add(new Movie("Господин за един ден", 1983, 83, "България", 19, description));
            List<string> gentlemenForADayActors = new List<string>() { "Тодор Колев мъж", "Йорданка Стефанова жена", "Иван Григоров мъж", "Велико Стоянов мъж", "Стоян Гъдев мъж" };

            description = descriptions[28];
            movies.Add(new Movie("Тримата от запаса", 1971, 97, "България", 20, description));
            List<string> the3ofTheStockActors = new List<string>() { "Никола Анастасов мъж", "Кирил Господинов мъж", "Георги Парцалев мъж", "Вълчо Камарашев мъж" };

            description = descriptions[29];
            movies.Add(new Movie("Мъжки времена", 1977, 125, "България", 21, description));
            List<string> menTimesActors = new List<string>() { "Григор Вачков мъж", "Мариана Димитрова жена", "Павел Поппандов мъж", "Велко Кънев мъж", "Теофил Баделов мъж" };

            foreach (var m in movies)
            {
                bc.Add(m);

            }
            bc.AddActorsInMovie(titanicActors, 1);
            bc.AddActorsInMovie(avatarActors, 2);
            bc.AddActorsInMovie(terminatorActors, 3);
            bc.AddActorsInMovie(OhGrandDadActors, 4);
            bc.AddActorsInMovie(duskActors, 5);
            bc.AddActorsInMovie(redHatActors, 6);
            bc.AddActorsInMovie(avengersActors, 7);
            bc.AddActorsInMovie(theAlienActors, 8);
            bc.AddActorsInMovie(blueLagunaActors, 9);
            bc.AddActorsInMovie(anabelActors, 10);
            bc.AddActorsInMovie(theConjuringActors, 11);
            bc.AddActorsInMovie(theEmptyManActors, 12);
            bc.AddActorsInMovie(theHappyDeadDayActors, 13);
            bc.AddActorsInMovie(apostleActors, 14);
            bc.AddActorsInMovie(theAssaultActors, 15);
            bc.AddActorsInMovie(forTheSoulActors, 16);
            bc.AddActorsInMovie(monstersOODActors, 17);
            bc.AddActorsInMovie(angryBirdsActors, 18);
            bc.AddActorsInMovie(despicableMeActors, 19);
            bc.AddActorsInMovie(indianaJonesActors, 20);
            bc.AddActorsInMovie(hobbitActors, 21);
            bc.AddActorsInMovie(lordOfTheRingsActors, 22);
            bc.AddActorsInMovie(fAndFuriousActors, 23);
            bc.AddActorsInMovie(fAndFurious6Actors, 24);
            bc.AddActorsInMovie(hedgehogActors, 25);
            bc.AddActorsInMovie(dogDrawerActors, 26);
            bc.AddActorsInMovie(timeDiffActors, 27);
            bc.AddActorsInMovie(gentlemenForADayActors, 28);
            bc.AddActorsInMovie(the3ofTheStockActors, 29);
            bc.AddActorsInMovie(menTimesActors, 30);

            genresId = new List<int>() { 9, 12 };
            bc.MapMovieAndGenre(1, genresId);
            genresId = new List<int>() { 1, 6, 10 };
            bc.MapMovieAndGenre(2, genresId);
            genresId = new List<int>() { 1, 5, 10 };
            bc.MapMovieAndGenre(3, genresId);
            genresId = new List<int>() { 3 };
            bc.MapMovieAndGenre(4, genresId);
            genresId = new List<int>() { 2, 5, 12 };
            bc.MapMovieAndGenre(5, genresId);
            genresId = new List<int>() { 12 };
            bc.MapMovieAndGenre(6, genresId);
            genresId = new List<int>() { 1, 5 };
            bc.MapMovieAndGenre(7, genresId);
            genresId = new List<int>() { 1, 2, 5 };
            bc.MapMovieAndGenre(8, genresId);
            genresId = new List<int>() { 2, 9, 12 };
            bc.MapMovieAndGenre(9, genresId);
            genresId = new List<int>() { 8, 10 };
            bc.MapMovieAndGenre(10, genresId);
            genresId = new List<int>() { 8, 10 };
            bc.MapMovieAndGenre(11, genresId);
            genresId = new List<int>() { 4, 8, 12 };
            bc.MapMovieAndGenre(12, genresId);
            genresId = new List<int>() { 8, 10 };
            bc.MapMovieAndGenre(13, genresId);
            genresId = new List<int>() { 8, 10 };
            bc.MapMovieAndGenre(14, genresId);
            genresId = new List<int>() { 1, 10 };
            bc.MapMovieAndGenre(15, genresId);
            genresId = new List<int>() { 2, 3, 11 };
            bc.MapMovieAndGenre(16, genresId);
            genresId = new List<int>() { 11 };
            bc.MapMovieAndGenre(17, genresId);
            genresId = new List<int>() { 3, 11 };
            bc.MapMovieAndGenre(18, genresId);
            genresId = new List<int>() { 2, 3, 11 };
            bc.MapMovieAndGenre(19, genresId);
            genresId = new List<int>() { 1, 2 };
            bc.MapMovieAndGenre(20, genresId);
            genresId = new List<int>() { 1, 2, 5 };
            bc.MapMovieAndGenre(21, genresId);
            genresId = new List<int>() { 1, 2, 5 };
            bc.MapMovieAndGenre(22, genresId);
            genresId = new List<int>() { 1, 4 };
            bc.MapMovieAndGenre(23, genresId);
            genresId = new List<int>() { 1, 4 };
            bc.MapMovieAndGenre(24, genresId);
            genresId = new List<int>() { 3 };
            bc.MapMovieAndGenre(25, genresId);
            genresId = new List<int>() { 3 };
            bc.MapMovieAndGenre(26, genresId);
            genresId = new List<int>() { 7, 12 };
            bc.MapMovieAndGenre(27, genresId);
            genresId = new List<int>() { 3, 12 };
            bc.MapMovieAndGenre(28, genresId);
            genresId = new List<int>() { 3, 12 };
            bc.MapMovieAndGenre(29, genresId);
            genresId = new List<int>() { 12 };
            bc.MapMovieAndGenre(30, genresId);

        }
        private void EnsureDateBaseIsCreated()
        {
            bc = new MovieBusiness();//create database
            if (!bc.CheckIsFulled())
            {
                FullDatabase();
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            groupBox1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;

        }


        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Parent = Program.myForm;
            //pictureBox.Image = Image.FromFile("55.jpg");
            //pictureBox.Location = new Point(253, 25);
            //pictureBox.Size = new Size(100,100);
            //pictureBox.Visible = true;
            //pictureBox.BringToFront();
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var formAction = new FormAction();
            formAction.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formAction = new FormAction();
            formAction.Show();
            this.Hide();
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filename = data as string[];
                if (filename.Length > 0)
                {
                    pictureBox2.Image = Image.FromFile(filename[0]);
                }
            }
        }
        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
