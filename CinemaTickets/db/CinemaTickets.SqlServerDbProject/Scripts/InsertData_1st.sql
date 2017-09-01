USE [CinemaTickets]
GO

------- GENRES

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Анимация');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Арт-хаус');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Балет');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Биографический');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Боевик');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Вестерн');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Военный');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Детектив');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Документальный');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Драма');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Искусство');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Исторический');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Комедия');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Криминал');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Мелодрама');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Мистика');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Мультфильм');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Опера');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Приключения');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Рекламные ролики');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Романтика');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Семейный');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Спектакль');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Спорт');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Театр');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Трагедия');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Триллер');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Ужасы');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Фантастика');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Футбол');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Фэнтези');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Genres]([Id], [Name]) VALUES (@@IDENTITY, N'Экшн');


-------- ACTORS

INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Том', N'Круз');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Рассел', N'Кроу');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Аннабелль', N'Уоллис');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Джейк', N'Джонсон');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Кортни', N'Б. Вэнс');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Марван', N'Кензари');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Джои', N'Кинг');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Морган', N'Фриман');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Майкл', N'Кейн');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Питер', N'Серафинович');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Кристофер', N'Ллойд');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Алан', N'Аркин');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Мэтт', N'Диллон');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Нуми', N'Рапас');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Орландо', N'Блум');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Тони', N'Коллетт');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Майкл', N'Дуглас');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Джон', N'Малкович');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Акшай', N'Кумар');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Тосин', N'Коул');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Эделайо', N'Эдедайо');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Бен', N'Кингсли');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Антонио', N'Бандерас');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Лиам', N'МакИнтайр');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Чэд', N'Линдберг');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Габриэлла', N'Райт');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Кунг', N'Ле');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Яна', N'Маринова');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Марк', N'Смит');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Башар', N'Рахаль');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Дзиро', N'Ван');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Мэттью', N'МакКонахи');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Энн', N'Хэтэуэй');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Джессика', N'Честейн');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Маккензи', N'Фой');
INSERT INTO [Actors]([FirstName], [LastName]) VALUES (N'Дэвид', N'Гяси');


---DIRECTORS

INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Кристофер', N'Нолан');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Тарсем', N'Сингх');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Ридли', N'Скотт');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Джозеф', N'Косински');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Даг', N'Лайман');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Луи', N'Летерье');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Гленн', N'Фикарра');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Джон', N'Рекуа');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Джеймс', N'Ганн');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Тим', N'Миллер');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Дункан', N'Джонс');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Нэнси', N'Майерс');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Оливье', N'Накаш');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Эрик', N'Толедано');
INSERT INTO [Directors]([FirstName], [LastName]) VALUES (N'Марк', N'Форстер');



---WRITERS

INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Тони', N'Мошер');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Джон', N'Салливан');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Николай', N'Арсель');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Акива', N'Голдсман');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Андерс Томас', N'Йенсен');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Джереми', N'Хафт');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Эд', N'Гонзалез');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Стивен', N'Багатурян');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Курт', N'Джонстад');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Энтони', N'Джонстон');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Эдгар', N'Райт');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Гэри', N'Спинелли');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Эрик', N'Пирсон');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Стэн', N'Ли');
INSERT INTO [Writers]([FirstName], [LastName]) VALUES (N'Ларри', N'Либер');


--CITIES

INSERT INTO [Cities]([Name]) VALUES (N'Нью-Йорк');
INSERT INTO [Cities]([Name]) VALUES (N'Лос-Анджелес');
INSERT INTO [Cities]([Name]) VALUES (N'Чикаго');
INSERT INTO [Cities]([Name]) VALUES (N'Хьюстон');
INSERT INTO [Cities]([Name]) VALUES (N'Филадельфия');
INSERT INTO [Cities]([Name]) VALUES (N'Финикс');
INSERT INTO [Cities]([Name]) VALUES (N'Сан-Антонио');
INSERT INTO [Cities]([Name]) VALUES (N'Сан-Диего');
INSERT INTO [Cities]([Name]) VALUES (N'Даллас');
INSERT INTO [Cities]([Name]) VALUES (N'Сан-Хосе');
INSERT INTO [Cities]([Name]) VALUES (N'Остин');
INSERT INTO [Cities]([Name]) VALUES (N'Индианаполис');
INSERT INTO [Cities]([Name]) VALUES (N'Сан-Франциско');
INSERT INTO [Cities]([Name]) VALUES (N'Детройт');
INSERT INTO [Cities]([Name]) VALUES (N'Сиэтл');


--COUNTRIES

INSERT INTO [Countries]([Name]) VALUES (N'Непал');
INSERT INTO [Countries]([Name]) VALUES (N'Австралия');
INSERT INTO [Countries]([Name]) VALUES (N'Филиппины');
INSERT INTO [Countries]([Name]) VALUES (N'Норвегия');
INSERT INTO [Countries]([Name]) VALUES (N'Бразилия');
INSERT INTO [Countries]([Name]) VALUES (N'Чили');
INSERT INTO [Countries]([Name]) VALUES (N'Индия');
INSERT INTO [Countries]([Name]) VALUES (N'Уганда');
INSERT INTO [Countries]([Name]) VALUES (N'Швейцария');
INSERT INTO [Countries]([Name]) VALUES (N'Канада');
INSERT INTO [Countries]([Name]) VALUES (N'Кения');
INSERT INTO [Countries]([Name]) VALUES (N'Италия');
INSERT INTO [Countries]([Name]) VALUES (N'Колумбия');
INSERT INTO [Countries]([Name]) VALUES (N'Аргентина');
INSERT INTO [Countries]([Name]) VALUES (N'Намибия');
INSERT INTO [Countries]([Name]) VALUES (N'Китай');
INSERT INTO [Countries]([Name]) VALUES (N'США');
INSERT INTO [Countries]([Name]) VALUES (N'Россия');
INSERT INTO [Countries]([Name]) VALUES (N'Германия');
INSERT INTO [Countries]([Name]) VALUES (N'Испания');
INSERT INTO [Countries]([Name]) VALUES (N'Англия');


----LANGUAGES

INSERT INTO [Languages]([Name]) VALUES (N'Китайский');
INSERT INTO [Languages]([Name]) VALUES (N'Испанский');
INSERT INTO [Languages]([Name]) VALUES (N'Английский');
INSERT INTO [Languages]([Name]) VALUES (N'Португальский');
INSERT INTO [Languages]([Name]) VALUES (N'Русский');
INSERT INTO [Languages]([Name]) VALUES (N'Немецкий');
INSERT INTO [Languages]([Name]) VALUES (N'Французский');
INSERT INTO [Languages]([Name]) VALUES (N'Итальянский');
INSERT INTO [Languages]([Name]) VALUES (N'Румынский');


---MOVIES

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Звездные войны: Пробуждение силы', N'Star Wars: Episode VII - The Force Awakens', 89, '2015-12-17', N'Да пребудет с вами сила! Продолжение эпической и классической саги в еще более масштабном формате. Действие происходит через 30 лет после «Возвращение Джедая». На планеты вновь надвигается опасность: Сила пробуждается, и те, кому она подвластна, хотят использовать ее в личных целях. Грядет новая межгалактическая война.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Охота на монстра', N'Zhuo yao ji', 89, '2015-12-17', N'Симпатичный маленький монстр Хуба - это ребенок человеческого мужчины и королевы монстров. Его преследуют как люди, ненавидящие монстров, так и монстры, которые пытаются схватить его. Действие происходит в средневековом Китае.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'5-я волна', N'The 5th Wave', 89, '2015-12-17', N'Первая волна оставила за собой мглу. От второй успели убежать только самые везучие. Но едва ли можно назвать везучими тех, кто уцелел после третьей. А четвертая волна стерла все человеческие законы, взамен же установила свой, один-единственный: хочешь жить — не верь никому. И вот уже накатывает пятая волна…');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Панда Кунг-Фу 3', N'Kung Fu Panda 3', 89, '2015-12-17', N'Отец По, которого давно считали пропавшим, внезапно возвращается и вместе с сыном отправляется в тайный рай панд, где их ждет встреча со многими новыми забавными героями. Впрочем, когда вор со сверхъестественными способностями по имени Кай начинает побеждать мастеров кунг-фу по всему Китаю, По вынужден совершить невозможное - организовать обучение целого поселка, населенного его веселыми неуклюжими братьями, чтобы превратить их в идеальную группу «Панды Кунг-Фу»!');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Антиганг', N'Antigang', 89, '2015-12-17', N'Бывалый коп Бюрен не любит правила. Чтобы держать под жестким контролем преступный мир, его боевая группа предпочитает использовать методы, выходящие за рамки закона. С приходом нового босса Ленуара им приходится немного поумерить пыл, и действовать подпольно.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'13 часов: Тайные воины Бенгази', N'13 Hours', 89, '2015-12-17', N'Новый масштабный проект, основанный на реальных событиях от легендарного Майкла Бэя. В основу легли трагические события 2012 года, которые происходили в охваченной протестами Ливии. Уровень угрозы в этой стране было признано чрезвычайно высоким. Мирное население и работники дипломатического корпуса находились под постоянным прицелом боевиков, совершивших атаку на посольство США. Элитный отряд бывших военнослужащих оперативно отправляется в город Бенгази. В их руках сотни жизней, времени для выполнения операции по обезвреживанию критически мало.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'И грянул шторм', N'The Finest Hours', 89, '2015-12-17', N'Сюжет фильма основан на реальных событиях, произошедших в 1952 году, когда сотрудники береговой охраны в самый разгар шторма, используя деревянные моторные лодки, пытались спасти экипаж двух нефтяных танкеров.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Дэдпул', N'Deadpool', 89, '2015-12-17', N'Бывший солдат, ставший наемником спецназа, поучаствовал в нестандартном эксперименте, пытаясь вылечить рак. Благодаря этому Уэйд Уилсон получил повышенную способность к исцелению, невероятную силу и ловкость, а также неустойчивое психическое состояние и сформировал особый черный юмор. Однако его кожа оказалась изуродованной. В герое рождается новая личность - Дэдпул. Вооружившись новыми способностями и маниакальным чувством юмора, Уэйд Уилсон выходит на охоту за тем человеком, который разрушил его жизнь и похитил любимую девушку.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Гордость и предубеждение и зомби', N'Pride and Prejudice and Zombies', 89, '2015-12-17', N'Фильм является захватывающей и страшной интерпретацией известного романа британской писательницы Джейн Остин. Загадочная чума появилась в Великобритании в XIX веке. Люди стали ходячими мертвецами, что едят живую человеческую плоть. В таких условиях многому пришлось измениться. Смелая героиня Элизабет Беннет не только красивая и умная, она также мастер боевых искусств и оружия. Наставником для Элизабет и ее сестер стал молодой и привлекательный мистер Дарси. Девушке приходится объединиться с учителем на пропитанном кровью поле боя, чтобы освободить страну от зомби. Станут герои парой в этом опасном мире?');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Пернатая банда', N'El Americano: The Movie', 89, '2015-12-17', N'Как и все подростки, попугай Куко обожает находить занятия поинтереснее, чем помогать старшим в скучных домашних делах. Например, фанатеть от своего любимого телегероя, крутого супер-пернатого Эль Американо! Все меняется, когда банда птиц-раздолбаев грозится забрать у отца Куко цирковую арену, поколениями принадлежащей их семье. Куко решает, что без помощи Эль Американо ну никак не обойтись и он отправляется в полное опасностей путешествие в Голливуд, в конце пути открыв супергероя внутри себя самого.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Боги Египта', N'Gods of Egypt', 89, '2015-12-17', N'Некогда мирное и процветающее египетское царство погружается в хаос: беспощадный бог тьмы Сет убивает своего брата Осириса и узурпирует трон. Вызов ему неожиданно бросает простой смертный, находчивый молодой вор. Чтобы вернуть к жизни свою прекрасную возлюбленную, ему приходится заручиться поддержкой могущественного и мстительного бога Гора.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Безумный Макс: Дорога ярости', N'Mad Max: Fury Road', 89, '2015-12-17', N'Сюжет фильма рассказывает о том, как после мести за смерть жены и сына, Макс Рокатански (Том Харди) покинул ряды «Основного силового патруля», и поехал в пустыню, где скитается в одиночестве, пока мир медленно катится в пропасть в результате нефтяного кризиса и глобальной войны. У Макса по большому счету есть только один друг - его машина «Перехватчик». Нашему герою нужно научиться выживать в пост-апокалиптической пустоте и соревноваться с жестокими, безжалостными воинами, проживающими здесь. Макс встречает императрицу Фюриозу (Шарлиз Терон) - женщину, которая хочет пересечь пустыню.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Братья из Гримсби', N'Grimsby', 89, '2015-12-17', N'Британская комедия от создателя "Бората" и "Диктатора" Саши Барона Коэна. У Нобби есть все, чего только может пожелать человек из бедного рыбацкого городка Гримсби: самая красивая девушка в Англии и 9 детей. Но футбольному хулигану в жизни не хватало родного брата. Вот уже 28 лет Нобби пытается найти Себастьяна. Мальчиков разлучили в детстве при усыновлении разные семьи. Узнав о местонахождении младшего брата, хулиган отправляется в путь немедленно. Но он не знает, что Себастьян работает наемником секретной службы МИ6 и только раскрыл заговор, который угрожает безопасности всего мира.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Крутые чуваки', N'The Nice Guys', 89, '2015-12-17', N'Лос-Анджелес, 1970-е годы. Незадачливого частного детектива Холланда Марча (Райан Гослинг) и костолома Джексона Хили (Расселл Кроу) нанимают для распутывания дела о возможном самоубийстве старлетки. Легкое и неважное, казалось бы, дело, превращается в запутанный и шокирующий преступный сговор, в котором замешаны высшие чиновники. Детективам нужно не только привыкнуть к нестандартным профессиональным методам друг друга, но и остаться в живых среди выстрелов и взрывов.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Отряд самоубийц', N'Suicide squad', 89, '2015-12-17', N'Правительство решает дать команде суперзлодеев шанс искупить грехи. Подвох в том, что им поручают миссию, где они, скорее всего, погибнут. Показы в IMAX 3D состоятся только в Днепре, в кинотеатре Мультиплекс, ТРЦ "Dafi"');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Автобан', N'Collide', 89, '2015-12-17', N'Захватывающий экшн от легендарного продюсера Джоэла Сильвера ("Хищник", "Крепкий орешек", "V значит Вендетта", "Матрица", "Шерлок Холмс"). Чтобы достать денег на лечение для своей девушки, Кейси Штайн решает вернуться к криминальному прошлому и ограбить местного гангстера. Однако план срабатывает совсем не так, как хотелось. С этого момента и начинаются безумные гонки по автобанам Германии.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Аудитор', N'The Accountant', 89, '2015-12-17', N'Лента расскажет о жизни математического гения Кристиана Вульфа. Основав свою аудиторскую фирму, он консультировал опасные преступные организации и сам работал наемным убийцей.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Джек Ричер: Не отступай', N'Jack Reacher: Never Go Back', 89, '2015-12-17', N'Продолжение известного боевика с Томом Крузом в главной роли. Джек Ричер решает вернуться в 110 подразделение военной полиции, чтобы поблагодарить свою коллегу - майора Сьюзан Тернер, которая однажды очень ему помогла. Но оказавшись в части, Ричер узнает, что Сьюзан недавно арестовали за получение взятки, а его самого обвиняют в убийстве 16-летней давности, о событиях которого он ничего не помнит. Странное стечение обстоятельств или чей-то злой замысел? С этого момента у Джека начинается много неприятностей и приключений.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Изгой-один: Звёздные войны. Истории', N'Rogue One: A Star Wars Story', 89, '2015-12-17', N'Любимая сага "Звездные войны" возвращается на экраны! Группа повстанцев бросает вызов Империи и решает захватить чертежи совершенного оружия "Звезды смерти". Во главе отряда становится бывшая преступница, смелая и отважная Джин Эрсо. Узнав об этом, Император посылает для борьбы с мятежниками своего самого лучшего и самого могущественного приспешника - Дарта Вейдера. Это означает лишь одно: теперь война будет идти не на жизнь, а на смерть.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Обитель зла: Финальная битва', N'Resident Evil: The Final Chapter', 89, '2015-12-17', N'Зрелищное завершение франшизы "Обитель зла", собравшей более миллиарда долларов в мировом прокате! Элис (Милла Йовович) осталась последней надеждой человечества на спасение. Она должна вернуться к исходной точке, городу Раккун-Сити, ведь именно там корпорация "Амбрелла" собирает свои силы, чтобы нанести сокрушительный финальный удар.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Терминатор 2: Судный день 3D', N'Terminator 2: Judgment Day 3D', 89, '2015-12-17', N'Легенда вернулась. Новейшие 3D-технологии от команды, работавшей над «Аватаром», и революционные спецэффекты в одном из лучших фантастических фильмов всех времен. Неуязвимый киборг нового поколения прибывает в наше время с миссией убить молодого Джона Коннора, будущего лидера сопротивления, которому суждено окончить войну людей и машин. Но на защиту Джона успевают отправить перепрограммированного терминатора Т-800. Теперь будущее всего человечества зависит от исхода схватки, разворачивающейся в наши дни.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'На драйве', N'Baby Driver', 89, '2015-12-17', N'Бейби - талантливый водитель, который работает на криминального авторитета по имени Док. Весь бандитский мир знает, если "Малыш" за рулем - никакие копы не смогут их догнать. Все, что ему нужно - это музыка и скорость, которыми он глушит шум в ушах - память о трагедии детства. Но, однажды, в жизни драйвера появляется Дебора - девушка, в которую он влюбляется, и с которой хотел бы убежать куда подальше от подонков, с которыми он работал. Док дает водителю последнее задание, после чего обещает отпустить. Но, кажется, от такого преследования не удрать даже "Малышу". С этой передряги ему помогут выбраться разве только отвага, музыка и драйв.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Лего Фильм: Бэтмен', N'The Lego Batman Movie', 89, '2015-12-17', N'Новый фильм от Лего о любимом супергерое и его неожиданных приключениях с новым напарником!');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Король Артур: Легенда меча', N'King Arthur: Legend of the Sword', 89, '2015-12-17', N'Сюжет фильма повествует о молодом Артуре, который слоняется в окрестностях города Лондониум со своей бандой и своим происхождением совсем не интересуется. Так он живет до момента, когда судьба сводит его с магическим мечом Экскалибур. После этого Артур кардинально меняется. Он влюбляется, присоединяется к движению сопротивления и объединяет вокруг себя людей, чтобы вместе свергнуть тирана Вортигема, который убил родителей Артура и захватил трон.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Конг: Остров Черепа', N'Kong: Skull Island', 89, '2015-12-17', N'70-е годы прошлого века. Главный герой (Том Хиддлстон) организовывает экспедицию на Остров Черепа, чтобы найти там пропавшего брата и некую загадочную субстанцию. Путешественникам придется познакомиться с жуткими монстрами и всеми кошмарами места, где когда-то был пойман Кинг-Конг.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Логан: Росомаха', N'Logan', 89, '2015-12-17', N'В далеком будущем Логан (Хью Джекман) и Чарльз Ксавьер (Патрик Стюарт) остались без команды Людей Икс, однако лишь они могут противостоять могущественной корпорации, которая стремится уничтожить весь мир. Но годы дают о себе знать и помочь героям в борьбе против воров может только женский клон Росомахи.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Стражи Галактики 2', N'Guardians of the Galaxy Vol. 2', 89, '2015-12-17', N'Межгалактический блокбастер возвращается! На этот раз банда космических бродяг должна выяснить все детали биографии своего главаря Звездного Рыцаря. Их крутость высшего уровня - исключительно смелые, безусловно остроумные, склонные к авантюрам и небольшому криминалу. Они поразят вас снова в фантастическом экшне от Marvel.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Призрак в доспехах', N'Ghost in the Shell', 89, '2015-12-17', N'Новый научно-фантастический триллер с магнетической Скарлетт Йоханссон в главной роли! 2029 год. Кибертехнологии стали доступными каждому и практически все люди вживили себе нейронные импланты. Но вместе с тем развитие науки принесло человечеству опасную угрозу - хакеров, которые взламывают мозг и могут вмешиваться в политику. Майор-киборг элитного подразделения получает задание найти и обезвредить группу экстремистов, стремящихся уничтожить весь кибермир.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Три икса: Реактивизация', N'xXx: Return of Xander Cage', 89, '2015-12-17', N'Ксандер Кейдж возвращается, чтобы спасать мир! Получив шпионское задание, спецагент собирает команду экстремалов и отправляется на поиски секретного опасного оружия - "Ящика Пандоры".');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Приказ убить', N'Kill Command', 89, '2015-12-17', 'Недалекое будущее. На отдаленный остров в учебных целях высаживают группу морских пехотинцев. Настоящую суть задания бойцы поймут, только когда столкнутся с другими "островитянами" - высокотехнологичными роботами, которые руководствуются одним приказом.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Джон Уик 2', N'John Wick: Chapter Two', 89, '2015-12-17', N'Джон Уик возвращается! Когда его бывший коллега берет под свой контроль таинственную гильдию наемных убийц, Джон отправляется в Рим, чтобы сражаться с самыми опасными в мире киллерами.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Чудо-женщина', N'Wonder Woman', 89, '2015-12-17', N'Принцесса амазонок Диана всю жизнь живет на отдаленном райском острове, но однажды на его берегах случайно оказывается американский пилот. Юная воительница узнает о серьезном конфликте во внешнем мире из уст солдата и решает покинуть свой дом, чтобы помочь восстановить мир. Сражаясь бок о бок с людьми, дочь Зевса Диана найдет свое истинное предназначение и превратится в Чудо-Женщину.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Форсаж 8', N'The Fate of the Furious', 89, '2015-12-17', N'После расставания с Брайаном О Коннером у команды Доминика Торетто появляются новые враги, а его семья оказывается на грани разрыва.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Спасатели Малибу', N'Baywatch', 89, '2015-12-17', N'Как заставить молодого практиканта отвлечься от тусовок с моделями, знает Дуэйн Джонсон. Залив в безопасности, когда он на посту.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Ветреная река', N'Wind River', 89, '2015-12-17', N'Американская глубинка. Охотник Кори Ламберт из Департамента рыболовства в индейской резервации Ветряная Река во время прогулки находит недавно убитую женщину. ФБР отправляет на дело совсем неопытного агента Джейн Беннер, которая оказывается совсем не готова ко всем трудностям, что создает зимний Висконсин. Одной девушке не справиться, поэтому она просит Кори, как местного жителя, помогать ей в расследовании. И они многое узнают... Как минимум то, что убийство было не одно, а целая серия. Ветряная Река - место, где перемешались законы природы и законы человечества. И непонятно, какие из них руководят всем вокруг.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Лига справедливости', N'Justice League', 89, '2015-12-17', N'Понимая, что существуют угрозы, с которыми невозможно справиться в одиночку, Бэтмен и Супермен создают совершенно новую команду, собрав в ней самых могущественных защитников человечества. Объединившись и забыв о разногласиях, героям предстоит столкнуться лицом к лицу со страшной угрозой в лице могущественного правителя планеты Апоколипс — Дарксайда, чья мощь способна обратить в прах не только Землю, но и всю галактику.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Kingsman: Золотое кольцо', N'Kingsman: The Golden Circle', 89, '2015-12-17', N'Эггси и Мерлин соберутся навестить своих коллег из США — членов организации «Statesman», после того, как штаб-квартира «Kingsman» была разрушена Поппи.');

INSERT INTO [Entities] DEFAULT VALUES;
INSERT INTO [Movies]([Id], [Name], [OriginalName], [Duration], [ReleaseDate], [Description]) 
VALUES (@@IDENTITY, N'Черная пантера', N'Black Panther', 89, '2015-12-17', N'С первого взгляда можно решить, что Ваканда — обычная территория дикой Африки, но это не так. Здесь, в недрах пустынных земель, скрываются залежи уникального металла, способного поглощать вибрацию. Многие пытались добраться до него, разоряя всё на своём пути и принося смерть аборигенам, но каждый раз таинственный дух саванны — Чёрная Пантера — вставал на защиту угнетённых. Спустя много лет беда снова приходит в Ваканду, и в этот раз враг заручился поддержкой современных технологий. Когда шансов почти не остаётся, Т`Чалла, молодой принц Ваканды, узнаёт, что именно ему предстоит возродить легенду и продолжить вечную борьбу, надев маску Чёрной Пантеры.');


----MOVIEACTORS

INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 31);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 31);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 31);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 31);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 19);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 8);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 35);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 23);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 13);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 26);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 29);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 15);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 27);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 2);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 12);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (39, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (40, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (41, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (42, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (43, 6);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (44, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (45, 25);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (46, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (47, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (48, 18);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (49, 5);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (50, 7);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (51, 31);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (52, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (53, 10);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (54, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (55, 11);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (56, 1);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (57, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (58, 36);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (59, 14);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (60, 3);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (61, 33);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (62, 32);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (63, 22);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (64, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (65, 28);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (66, 24);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (67, 9);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (68, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (69, 30);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (70, 4);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (33, 34);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (34, 16);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (35, 20);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (36, 21);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (37, 17);
INSERT INTO [MovieActors] ([MovieId], [ActorId]) VALUES (38, 12);


----MOVIECOUNTRIES

INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (43, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (44, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (45, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (46, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (47, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (48, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (49, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (50, 3);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (51, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (52, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (53, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (54, 3);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (55, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (56, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (57, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (58, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (59, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (60, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (61, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (62, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (63, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (64, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (65, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (66, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (67, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (68, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (69, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (70, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (43, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (44, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (45, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (46, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (47, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (48, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (49, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (50, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (51, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (52, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (53, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (54, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (55, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (56, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (57, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (58, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (59, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (60, 3);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (61, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (62, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (63, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (64, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (65, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (66, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (67, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (68, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (69, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (70, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (43, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (44, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (45, 8);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (46, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (47, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (48, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (49, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (50, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (51, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (52, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (53, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (54, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (55, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (56, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (57, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (58, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (59, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (60, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (61, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (62, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (63, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (64, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (65, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (66, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (67, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (68, 8);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (69, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (70, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 8);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (43, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (44, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (45, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (46, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (47, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (48, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (49, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (50, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (51, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (52, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (53, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (54, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (55, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (56, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (57, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (58, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (59, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (60, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (61, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (62, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (63, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (64, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (65, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (66, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (67, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (68, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (69, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (70, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 20);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (43, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (44, 12);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (45, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (46, 13);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (47, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (48, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (49, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (50, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (51, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (52, 10);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (53, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (54, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (55, 4);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (56, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (57, 8);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (58, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (59, 21);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (60, 19);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (61, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (62, 15);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (63, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (64, 5);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (65, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (66, 11);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (67, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (68, 16);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (69, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (70, 7);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (33, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (34, 8);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (35, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (36, 14);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (37, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (38, 18);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (39, 1);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (40, 17);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (41, 2);
INSERT INTO [MovieCountries] ([MovieId], [CountryId]) VALUES (42, 11);


-----MOVIEDIRECTORS

INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (33, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (34, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (35, 4);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (36, 8);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (37, 9);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (38, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (39, 8);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (40, 10);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (41, 5);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (42, 15);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (43, 6);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (44, 12);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (45, 13);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (46, 12);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (47, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (48, 8);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (49, 3);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (50, 5);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (51, 11);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (52, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (53, 15);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (54, 8);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (55, 13);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (56, 9);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (57, 8);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (58, 1);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (59, 3);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (60, 3);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (61, 12);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (62, 10);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (63, 15);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (64, 11);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (65, 6);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (66, 14);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (67, 15);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (68, 13);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (69, 4);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (70, 13);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (33, 13);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (34, 9);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (35, 3);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (36, 6);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (37, 6);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (39, 14);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (40, 12);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (41, 7);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (42, 10);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (43, 15);
INSERT INTO [MovieDirectors] ([MovieId], [DirectorId]) VALUES (44, 1);


----MOVIELANGUAGES

INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (33, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (34, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (35, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (36, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (37, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (38, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (39, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (40, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (41, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (42, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (43, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (44, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (45, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (46, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (47, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (48, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (49, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (50, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (51, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (52, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (53, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (54, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (55, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (56, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (57, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (58, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (59, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (60, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (61, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (62, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (63, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (64, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (65, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (66, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (67, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (68, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (69, 5);
INSERT INTO [MovieLanguages] ([MovieId], [LanguageId]) VALUES (70, 5);


----MOVIEGENRES

INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 8);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 8);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 32);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 9);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 8);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 32);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 9);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 32);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 25);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (42, 21);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 9);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 7);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 9);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 6);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 1);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (39, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (40, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 29);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 17);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 26);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (53, 11);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (54, 32);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 4);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (64, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 18);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (67, 2);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (68, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (69, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (70, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (33, 20);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (34, 30);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (35, 22);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (36, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (37, 23);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (38, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (41, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (43, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (44, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (45, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (46, 24);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (47, 14);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (48, 5);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (49, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (50, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (51, 10);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (52, 16);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (55, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (56, 15);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (57, 3);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (58, 13);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (59, 19);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (60, 27);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (61, 31);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (62, 28);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (63, 12);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (65, 9);
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (66, 28);


----MOVIEWRITERS

INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (33, 12);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (34, 13);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (35, 9);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (36, 6);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (37, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (38, 8);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (39, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (40, 10);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (41, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (42, 3);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (43, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (44, 4);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (45, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (46, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (47, 1);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (48, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (49, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (50, 12);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (51, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (52, 12);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (53, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (54, 14);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (55, 3);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (56, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (57, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (58, 9);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (59, 3);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (60, 4);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (61, 3);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (62, 1);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (63, 10);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (64, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (65, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (66, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (67, 4);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (68, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (69, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (70, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (33, 4);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (34, 13);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (35, 5);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (36, 3);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (37, 8);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (38, 12);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (39, 8);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (40, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (41, 1);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (42, 12);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (43, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (44, 6);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (45, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (46, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (47, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (48, 14);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (49, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (50, 10);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (51, 6);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (52, 2);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (53, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (54, 13);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (55, 8);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (56, 10);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (57, 13);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (58, 11);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (59, 15);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (60, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (61, 10);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (62, 1);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (63, 7);
INSERT INTO [MovieWriters] ([MovieId], [WriterId]) VALUES (64, 14);


