using NetrunnerConsole.ProgramTypology;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace NetrunnerConsole
{
    internal class Program
    {
        public Player Player = new Player("Regina");
        public NetSystem theSystem = new NetSystem();

        public GameManager GameManager = new GameManager();
        

        public static string ascified = 
 @"
.'.  . .' `.-- -'' -' '... `. -.'--...'` ``  `'  - '..-  - '.... '-``  ' `- '   `` ``.  '-    -`  '-.  '- .```' `  '.`--' -..`' -.`. `'''.`.`' 
.'` - .``.'' ` -'`-`' ' ' --'  .`- '`'  - `- ---  -.'.'`' -  -.`   -   C~'  `  ' '-` `.-  -.' ' --`.'`'  .  -   '`` '.` -.`    --..  ``` '-`'  
` ``-  -`-` . -' `-`. ...   -'..` ``.`.` '.` . - `- ` - '-`` ---'`.' .5Hq^ -.   '  .`'`----'  -`  --''..  `-` ..-'. ..'- -' .-.`'''-`   .' ` --
-` ''--``'   ..'.```.....  `--' '-'  `'-'- '`.`. -`'   .--' .``-`.  .aggg6!- .- '`. ` . `   -` -'' ' '''-'   `-`   -  .-`- '`-''`  `'--    .  `
   . ''..-        ''--  '- .- '   ..'``-- ' -.'-` `  .`. -'    .`.'`yRWWQg4.`   `- '-.-  `` '.`' ..`-..  .- '.. -  '.'- -'.' -' `. `.`-`  '   `
'.--`.- `'. `.' -`'`  '.'. '         `.''-' `. -'`' `. `' -`- '..-->gWWHQWQ?.` ..  ..-.` --'' .. '. '  -`. '- '. `-.'..`.`-- - --.-`'-`''---'-'
-'.`    ``'' . .  ..      '-''`. ' '-. '-`. .` .''  . '--   -- -.-.xHRBRHHRV  `` ..-''  .. `  .` ..-`.-``` ..`` .`'`   ''.' .' ''..-`.'.- .''-'
` .-'``- ` - ` `..    ``  `  ``'.'' .` -`  `-'  '- ''-` ` '.     ``vgWRQQgHu`  ` -    ..  ` . -`   '-.`  '' .  `.-`. ` --`'--`. .`-'  ``-` .-' 
 .-'-` `'.`.`. .`- `' ` ` ``    -. .'- -' `..' .''   -'. -``.--~/v! lMgWQD2!>v?.-'-` ''  '  .-`.-.` ``-.. ' --' .' `-  .  ' ..- ''.. -. -  '  .
 -`..` -'  `- ``--.-.   . . --.''` '--.` -`-`- --`` --.` . `-`<@WBQ#=-*i(,vmgQg%.`  ..-.-.`.. ---.'' .-.  - .`.`  .`' .'.'---.`'-   -.` .   -`'
'-'  '` - . `--'`  -.`'. `.- -- .- `` -... ' `. .'- . `. - .-.,bWHRWgy- ,6gWgWH2-- - .        - '`  -'  '  '' . . `. ' ''` -- - .     .` -'  '.
```'  `''`  `'` -.` .... '`   -' .`--'``   ..-' -   .`'.` --'`  ;SWgHga>bgRRQu>-'     - `-'``  ' `  .'- -  -` -.  .` `.`.`.'''-`    `.`-' '. .'
   -.'`.- -'` .'.. -`-'  `  . . ''' . .` '.. '' `-   ' `i6qZt;''``tgHQQDBRQN?`-`.\y5K$='    `.. -.- -' ..- ' '.'-- -  .-` `.'.  `''' ` '' ''- `
.. ` '`   ' -` ' .  '-'--   ' --`  '-`.-'.'' `-- . -' -'OHBgQBMf:' 4gWHQWWBv -<u&ggRWHF-.  -`'. ... --  . - - . -`- '.-'  '.`.'    . .` - '-` '
` `-'  .''..``''- ` '``'' `.   .  ---`'.-`.`. -'-`'.'``-+1$@BggR&Y-!ORHRHW5'!3QgBWRMj}: -.  .'. `''``'`  .-  .'`'' ``' -.-   -..'-``   '-'. ' `
- ` -`.`` `- - - .' --``-  .' '' --.``-`  ` ` `-'+<*>< -.'.'i6WHRRd+YBBgHgr)OgBWWI; -  -:>*=;>^` . . ... `-'-''`'' .-'--  .`.   ''.- --.``..` .
 '`  - `-.  `'  . .`-f!-' ``.-` `-``-.- .'.:xCSORBQBgBQM%ui_.-iDQRB&iWHWW87RWQRq*'.<TaG&BRgWgHHO9jv:` '`.  '`.` -.-- '. ""z.` -. - ' ...- -`-.- 
 .'`'.`''...`-' .'  >BD2_.'- -`-''`''`` :}EggWWHWgRRWggWHgRHA1_<GWWBDHBQRDWWgWZ^<yMQWHBRQQQgQgBWgBB@Xi ..  `-' .--'` '""kWO '.-.-.- ''``   `.` .
.. .   -` - ' ..'.  ;RWBNT. -   `  ''-^1&QQQHgBWNK9ZAqNgWgHHHWB4rhBBgggBRWHgH#|XQHHRRgQROwX$6MBWBQQWWQ0}' .`-`` `-- ,ugQgQ-   `'-` `.-' ``     
.-`  '. `-''-`` . .->gHRHgV ':]F1,-` /MgQgRRgS1r`----  _voOWBHQWH#&BRggHQQHBMwWRBWHQGy(^  --.':/zURWHHgRG; - +Tov'-:pWRBgB-`- ' -`  ''  '`.- `-
 - ``   `  -' . '.`- AgBBQg+>ORWQm -fggHWBg4""-. ..'` ..   -iPHgRQWQHRBWWHRBRQgRHQgu= -. - ' .`'. .?XHWgWW@]- OQBQ9_|BBWHQF- .   - `'`'`` '---`.
 '`  `''-.'`---` 75ezvYXGPv.PgRR@(.aQQWWW8;   .'. `  . -.'-.`(mgHBBRWWQQWRHgQQRH$+  '  ..`   . ' `.'/OggHWBf YggBgV xhqVYvfkei  -  ` -`.. ` ``'
`   -`'` ' -`  '-OBBHRNV=`-+BQgW[-jBggWWX,`'`-' .' ` `'`  '`.:>$HHWHBHRWRBWBBQQy<! .. -.'  ..--`' ''',AggBRQ1-sRQBH:` ?ZBQBQRA'.'-' '-`- . '.  
...' ..  ` `-```-:LuMBHgBk>?RRBH:vgBQWW$ ``'.-.... -. -  :YXORBRgBBgRRWHHggHgRHBWQO$}^   '.  ``.-.  -.,EWgHgW(rBRBW</6HQQQd2}! -     `-'-   .. 
'`' '.`-.rTu59wE6XjT)?5BBBg$BBBg>OgRBgK_''`..`''- ` `` `T@BQBWRBgHgWgWQWBQBWHHWRWWgBgNY ---  `.  '''.`.^ORQHHK|BggWZBBHRe;/xu#$A%65jc*'-.--`. .
`-    +FDgHHWQgRQgWRggd0HWBRRgBR%BWgQB1i{i?+ ..-'-`.. `zRHBBu/^^""]bWRHgWQQggAl<,+)3RRBRL . `' . ''`<)vcvsQQgQB#BBBQHgRWkqBgBQHgggQBRWWMf< ' .''
-.`  1NHRWQBWWDONggWHQQgHHRHgHBgQBBQgHQHHBRQO4= '-' `' MQRBY``' .' AWgBBggWX-`. .''zWHB% `... .`|e@WWHQgWgWHHWgQQQWWQHWgHQHRBBDODQHgHHHR&1--.-.
```-eHWWQWNf?: ' -+xOHWQBHQRRQBRWRBWBBHMh9OQgQQu `'`  -eBWH%r- ikSziHWBHgWQ/jPZ/`';mgHB$..'`-`_3RBWQOE9OBRgBBQBggRHRBRWHRg8[>`-' ^/uDWRQBRF  '-
  -}HHHWRk~-`-`.-=kQHBWgWQWHBQHgHRBHBB} - -;MHWgo- -'--!PRQHBgNRQQBvRggWWHN|gBgBDNHgRQ%:'' . 'ogHWd= .-'THQgHHBRRBgBBBHHHgRHk""`'.`' _kgBBgW7..-
`-'MBRWRm.-.--' /WggWMaFIOBgRHQRHgQHQo    '.|gRB@ ' '`-' ?eMRHHW@X\=HWgBBBQ</ZNWWWRqC/`` .'.''@gQg=.` .'`aBWQgRRgWgWgO4nVNggWW\ --`- 'KRHRWO.` 
'-^HHBHRi  .  -.ZWRRX . `'=kWQggBHHgg]`' . `VBgWM`  '.- - -`.>+<  .9gHRWgRBw`..<<+-' - ' `-   MWQHo'   -`iQHWQWBHHRk""``' '$ggW$  ` ..`iHQWWQ>  
'`>BWBBg~' -  `-jgBQX-`--   vOWQRRBBR; .  iOHHQM) '``. <il1ff1[/_.|QQWQQBQQR/-,?cYttz[i>.  `'.?NWRgO[.-' =RRBgBQQMv. `  - 5BRHj``.' '`_BHBQg< -
``!gBWWg+ ..  --_dRRRX(` .' .-{&QWBRWl`':XHWQgu!  - ?aNHRgRBRHWRBpjisWRWRgyvtGBWBWQWHHgQ@a? .`'+VQRQBE!-'iQQQHHQ}` '. ..|ZgWRb^``--. '<QWRRR_`'
 ``$QgHg{ - -`` -^t&QBRNm#1r` `\NBRBWk  EgQRm;`.`-^XHQWBO$JztF5MBQRgdWWRWgOBBRBMX2syFkMHgWH%>  -`+wHBHE' ZgggBQv '-=l4b@gRQQC_.  - -  xHBBQ%`''
---;WRgBq.----...` ~]5OQHRRWMy: |BHRQg*=BgRH+` - ~MWggk;-.'  `  =4BRWBHBgQggg4"" '  .  `""$QgQO<. ` !&QgH=<RWQHR}.^tMBQgWRMZT_`''  -.  .dBQHQv`- 
.` '3HRBHY`'''.'-`'''``~)TEgWg@1'tWHHB9=HRWO `'``tRWRw  '``.'  `  \NWBWHHgQHv  ``. `' -  wHQRu -`- ABWWv$BRgWe`7NRRBh1/~ -'-` -` -.``]QWRg% .- 
'.''<QRBg&"".``..-'` .`. .. ""$WHW$,OWHRB1t99Y `.' sHRBe ` ` -  -'`-.4HWBQBQHw. ' ' .'`. `.IWHHC.`''`{h%yLHWgB@_oQgB9r-`` '`-. `---`-';DBBWO~ -`.
 . . ygHRR@r `. .-`'  .-    `TpqC fRRggRi '.''`  <OWgWz!` ' .-'  .(RBgRgBBQQv`.`  '  `- YRQg@<..`.`-` )gWQHQe zbqt.'. '`.  ` -`' -`+MQQBO<  . .
  ``.-TRQBWNv .``-  . .'.'`  '' -'(RWgWRQ7    -`-`+5RBgNVY719QQ# >&RBWRgBHHWN| n&gPfLYCMRBQb"" '' - -`iDBHHHQT`-.-' '    ` . -`` `.""MgBBH/-.  -`
.     -|ORBQQC~. .```.   .`    `-`rBWgHBHRI^`-''  ` /VDBBgHQBW&z?@ggQQBRQRHRB&i}MHQgHHBgNZi .  .-'``zWBRgRWgl-.-.-. ` `'' '`'---.1DgHB&)`-``- -
'.''  - ~#BggHOv   `  ` ..'--  '  1QHHHRggQM[` '-```-` rcsffc;_sBHggRRRgBBHgBHHa,""[sttL? -.   -' `v0WQRBHgBH4-'` `-''..-  '   .*EHgBQP> `   .  
 -.'`''---lDgRBW6v-` - -'''`.  ``_OWRgRgHBWggMY,.''`   '-` '!1MWQBBRBWQgBHgHQBBB&z>'.'. `''. -.,cUgHWWQRgWHgN""`'.'`..-  -  - ;5gWQgRf.`.  `..  
 - .`  `'' rMQHgWQOf+ .''- -`'. >0HBHRgRWgBggHRBhz/> .- :|YZWWQBBBBRRBQBQRgHQgRggWRwy?>`.-.!|Y5DWBRHBRgQHRHHQO*- -    `. `_c9WBgWQ&i ``--. ``. 
-'`-'' -''` <OWgWBQgBKjl""^--`+i4@QQHgQRgBQQHBBWBQRgBB&DQRQWWgWWWWRQRgRgRHRRggBgHWQQRQBBH@@RHHQRRQHggHHgQgBBRWQBkc< `'_>is6BBRBRgQH(` .  - '.'` 
.` ``.`.` .--|HgQHgWWggQWRDDHRRHgHHRgBBgBHBBQBRWgRRgggRBBHHHHRgHBRgWHgBgQQHQRHWBWBRWWQBHRHHRRgBHQRgWgRHRgWQQHWRWHWH&DgggWRQHQWBgHY '` `' '''. .
-` ``'''''. ` 3QRBgRWRHWWQBQggWHRgRgQgQBHBgWRWRWD@OM0b966$Zk33#eVajnu2ojjjuua##43I3XZ599w9qmMO&&RBgHWWBggRggHHgWRHBQQWRWBHRBHHBHM -.  `'  `'' -
'`  `.`. ' .` \gWHWWRHQRBRBQDMd6Z#jt1[cv/r*+<_ _,_+++""*r\))vv{L]YT<`'.`'-'  ~L1Y7x[vii)(*""r<>+:^!^~+>;?vlLTso3ak%pO&HggWBWHRQRgQv-`  . .-` ' -.
'---''-'-'  '--|n$Iot{v(*<: !+*\vclTY, `.': '- vKRgWBBRBBQHBRWQRQv  ~y509I/  +GgWBQBBRWRQBHWgWD1~ . _~.. -LytTxv);<:!+=|v}zuI$u|---`' -`'` -` -
-- ` -  '  ``'   ,{Ttu3XAM&gBBRQQgRQi 'r9NRHOt^ -jWBHgHHRgRQBggHX'. OQWWHRH['-/BQRRHHgBHHBBQRU_`-1qDHRm7  !UWHHBWHRHWDOdX#FtTv `--``  - -'   .-
-'` `''`-`.-. `  '5BBHWRggWgQHRgHWRO' -wRHHBRQ$.',BHHgBQRggQRWBH8``-ZgHggg@;-'}WRRWWHHgBRBQRWi .[HWBWHRg,  3BRBHWWRQBggWgQgRBt   `'  -'  '....`
' `   `  ``  . .  _OgBWRWWBHRQWggRQHY` *6HQRHO\ -*gRQRRBQQHWgHWHQA<`-""7yTv, `1@RQgWgHHWgHgQRHC-`+hgQWWM7  ""NBBWWBWWRQHQgBQBR5   .'```` '`-`    
```  `-- -- .`''   rNWHQBRRQBQgWWRg@@o! -,=;+`..-YzT1TT{}l{viiv|)|(` '  -`-.<(/vviv}{L{T111zys<- '_;""<'`!TDWBRBRHBBQRBBQQQRO!' -.-` - `- -  '. 
' -` -  ```' ..``.` v#uFtTcvv(*>+^`.-'` `- ~!,!>>""""""(\?vvi]{{Y1YYTTT11TTfzfff11T1YY}cx}[vvvi)?rr>>+^: ` `.- ^++""(ii7TyjI$$A;-'`--' . '-''`  '. 
` ` ' ..`-- '   .. `` r/iixTtfn#4ZhP0MONNgWWWgBgBRWBBWgWHggHRggHHBRHHBHRRWWgWgWWWBgRBgHQQBWBWQggBgQBQHRNNOKGA9kaVjsy1}i|\>``.'    ` `- '-` ' ' 
 `-'`` '`''  .`. ''' 5WRHBHRQBQgWQHRBWBRBg@@OObGwAw$k$X33VeojouCutzszyftssyytCCjjjJFCIa4$Z55$hA9qpqMONWRggRRHRQHBBBHRgRBHHf -. .`'' - -.'.. ``-
` -  .'`. '.``. `` -'r4kX3C2t1Y{vv|r*<__'`-`.   ' '``- ``-'- '. -'` .`- - ''' ` '` -``---`  ` '-.' ''` .:_<;=/ii}Yfy24X$$j>`.. '`'-`.-```   --.
.   `.''.''`' ` ``. ` .'.-` -  - -''``.``. '.- -- -. - --.. `-  ``'` `' '. '    - '.''  '.     -. --...-`.`'- . -''' ''.``'` - -` .- .'.  .-'-`
    --' . .-.- '`'`` '-.    . - . `'-'.'- . - - '' '`.-``.`.`. --   ``  ` .   - `` ``'- ``-..'. - ..   .--'-' .'-  ` -'-.'  .' '''   `'` '    -
'. ' '`' .`  ..`  - ..-'.`` -.`'  `-`-'..''.' ' -.. -' `  -'  ' '     - `.' '`  -..'`' -        -- '-   '`  - `- '--` .' . '. ' .`---'` -`'--  
   .'  `' -  '`'   .  '   .' -` ' '`..`''` .- . . `- --. '`- .-`'` '    -.....   .`..'' ``'  `.  .` -..` ..''' '. `' --`'--  ``-'- '`-.' ....  
 .-.-. ..`.`` ' .'-''-` `  -   . '-.` -  ` ..  ' . .` ' -'.   -.'`'.`--.  .`--``.  .. `- '-' ` .-   - '` -`. ` ..` ```-.-``  '.   `-..   ' ''' 
.`''..-``-  '`  .  - ````-   -- .`  -.-   .'' ` '   ' .  -`-''- - '`.-`'  -..` `` -   -`-` `  - .'- -`.'-- - --'- ` '`-`'  `'..  --`   -'`. ' -";

        public Program()
        {
            LDLManager lDLManager = new LDLManager();

        }
        static void Main(string[] args) {
            Console.SetWindowSize(145, 50);
            Console.ForegroundColor
                = ConsoleColor.Red;

            Console.WriteLine(ascified);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine("All Hail the Majestic Regina! How can thy serfs help thee?");
            Thread.Sleep(1000);

            Program p = new Program();
            p.Player.CurrentDeckEquipped = new Deck();
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateWizardsBook(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateInvisibility(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateForceProtection(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateKiller4(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateSeeYa(Player.inst.CurrentDeckEquipped));

            p.Player.Area = p.theSystem.Areas[0];
            p.Player.Team = 1;




            Subgrid(p); //<-- Skal kunne tage et system ind!
        }

        private static void Subgrid(Program p) {
            for (int i = 0; i < 10000; i++) {
                if (Player.inst.CurrentDeckEquipped.SerialNumberRequired != "") {
                    Console.WriteLine("Interface Chip compromised, please install a new chip and type in serial number (4 character code)");
                    string rrr = Console.ReadLine();
                    if (rrr == Player.inst.CurrentDeckEquipped.SerialNumberRequired) 
                        {
                        Console.WriteLine("Serial number accepted");
                    }
                    continue;
                }

                if (Player.inst.CurrentDeckEquipped.Destroyed) {
                    Console.WriteLine("Everything was peaceful, until the fire nation attacked. Now we dead.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Your Command, thy Majesty?");

                string res = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                res = res.ToUpper();
                switch (res) {
                    case "READ":
                        Console.Clear();

                        Console.WriteLine();
                        p.Read();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case "SCAN":
                        Console.Clear();

                        Console.WriteLine("Choose Where to Scan");
                        Area area = p.ChooseArea();
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine(area.Scan(p.Player));
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case "STATUS":
                        Console.Clear();

                        Console.WriteLine("\tThine active programs art:");
                        Console.WriteLine();
                        if (Player.inst.ActivePrograms.Count == 0) {
                            Console.WriteLine("Naught and nothing");
                        }
                        else {

                            foreach (var item in Player.inst.ActivePrograms) {
                                Console.WriteLine(item.Name);
                            }
                        }



                        break;
                    case "MOVE":
                        Console.Clear();

                        Console.WriteLine("Choose where to go to");
                        ChooseGate().Transition(p.Player);
                        Console.WriteLine();
                        Console.WriteLine();


                        break;
                    case "HELP":

                        Console.WriteLine("");
                        Console.WriteLine("\t Available Commands: ");
                        Console.WriteLine();
                        Console.WriteLine("Scan");
                        Console.WriteLine("Run");
                        Console.WriteLine("Move");
                        Console.WriteLine("Use: let's you interact with interactive items in the world. But only if you have the right tools.");
                        Console.WriteLine("Look: scans your immediate surroundings");
                        Console.WriteLine("Read read a file in same area or in your deck.");
                        Console.WriteLine("Erase");
                        Console.WriteLine("Clear:");
                        Console.WriteLine("Status: *new* Shows what programs are active on you :D");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case "RUN":
                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine();
                        p.Run();
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case "ERASE":
                        Console.Clear();

                        Console.WriteLine("Not yet implemented");

                        break;

                    case "LOOK":
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("You look around.\nThou art at: ");
                        Console.WriteLine(p.Player.Area.Scan(p.Player));
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case "USE":
                        List<Useable> useables = new List<Useable>(); 
                        foreach (Useable item in Player.inst.Area.Entities.Where(x=> x is Useable))
                        {
                            useables.Add(item);
                        }
                        if (useables.Count == 0)
                        {
                            Console.WriteLine("No useable units in area.");
                        }
                        else
                        {
                            Console.WriteLine("Choose interactable item: ");

                            for (int ix = 1; ix < useables.Count+1; ix++)
                            {
                                Console.WriteLine($"{ix}: {useables[ix-1].Name}" );
                            }
                            int choice = int.Parse(Console.ReadLine());
                            useables[choice - 1].Use();
                        }


                        break;
                    case "":
                        Console.WriteLine("No input detected. Artest thou a moron?");
                        break;
                    case "CLEAR":
                        Console.Clear();
                        Console.WriteLine("Tidying up for Thee, Your Majesty");
                        break;
                    default:
                        Console.WriteLine("No such input, try again, Your Majesty!");
                        break;
                }
                TimePasses.Invoke();
            }
        }

        public static event TimerThing TimePasses;
        public delegate void TimerThing();

        private void Read()
        {
            Console.WriteLine("What would you like to read?");

            NetFile file = ChoseFile(Player.inst.Area);

            Console.WriteLine(file.Read());
            //Todo let them read their own deck.

        }

        private void Run()
        {
            Console.WriteLine(  );
            Console.WriteLine(  );
            Console.WriteLine("What would you like to Run?");
            //enumerate all available programs!
            NetProgram programToRun = ChooseProgram();
            if (programToRun == null)
            {
                Console.WriteLine("Dammit, thou art fucked, Your Highness!");
                return;
            }
            programToRun.Activate();


        }

        private void Scan()
        {
            Console.WriteLine("What would you like to scan?");

            int choice = int.Parse(Console.ReadLine());

        }
        public static Gate ChooseGate()
        {
            Console.WriteLine();
            Console.WriteLine();
            List<Gate> liste = Player.inst.Area.Gates.Where(x => x.Visible).ToList();

            for (int ix = 1; ix < liste.Count + 1; ix++)
            {
                Console.WriteLine(ix + ": " + (liste[ix - 1].GetName(Player.inst.Area)));

            }

            int res2 = int.Parse(Console.ReadLine());
            res2--;
            return liste[res2];
        }
        public static NetProgram ChooseEnemyProgram()
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < Player.inst.Area.Entities.Count + 1; i++)
            {
                if (Player.inst.Area.Entities[i - 1] is Player)
                {
                    continue;
                }
                Console.WriteLine(i + ": " + Player.inst.Area.Entities[i - 1].ToString());
            }

            if (Player.inst.Area.Entities.Count == 0)
            {
                Console.WriteLine("No targets!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return Player.inst.Area.Entities[res] as NetProgram;
        }
        private NetProgram ChooseProgram()
        {
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < Player.CurrentDeckEquipped.ProgramList.Count + 1; i++)
            {
                Console.WriteLine(i + ": " + Player.CurrentDeckEquipped.ProgramList[i - 1].ToString());
            }

            if (Player.CurrentDeckEquipped.ProgramList.Count == 0)
            {
                Console.WriteLine("No programs in deck!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return Player.CurrentDeckEquipped.ProgramList[res];
        }
        public static NetFile ChoseFile(Area area)
        {

            for (int i = 1; i < area.Entities.Where(x => x is NetFile).Count() + 1; i++)
            {
                Console.WriteLine(i + ": " + area.Entities.Where(x => x is NetFile).ToList()[i - 1].ToString());
            }

            if (area.Entities.Where(x => x is NetFile).Count() == 0)
            {
                Console.WriteLine("No Files in area!");
                return null;
            }

            int res = int.Parse(Console.ReadLine());
            res--;
            return area.Entities.Where(x => x is NetFile).ToList()[res] as NetFile;
        }

        private Area ChooseArea()
        {
            for (int ix = 1; ix < Player.Area.Gates.Count + 1; ix++)
            {
                //     Console.WriteLine(ix + ": " + (Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));
                Console.WriteLine(ix + ": " + (Player.Area.Gates[ix - 1].GetAreaName(Player.Area)));// Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));

            }

            int res2 = int.Parse(Console.ReadLine());
            res2--;
            return Player.Area.Gates[res2].Inside == Player.Area ? Player.Area.Gates[res2].OutSide : Player.Area.Gates[res2].Inside;
        }

    }
public class Useable : Entity
    {
        public Useable(Area area, NetSystem system)
        {
            Name = "Central Control (Interactable) *Crystal Ball*";
            Area = area;
            Area.Entities.Add(this);
            MySystem = system;
        }
        string manifest = "**Manifest for the Cargo Vessel SS Navishall/Hordik**\r\n\r\n**Date:** September 23, 2024  \r\n**Port of Departure:** Night City, Pacifica, United States  \r\n**Port of Arrival:** São Paulo, Brazil  \r\n**Captain:** Alexander Cortez  \r\n**First Officer:** Naomi Rivera  \r\n**Second Officer:** Blake Foster  \r\n**Chief Engineer:** Javier Silva  \r\n**Chief Mate:** Katarina Marlow  \r\n**Bosun:** Finn Matthews  \r\n**Crew Members:**  \r\n- Darius Collins (Deckhand)  \r\n- Ian Walsh (Deckhand)  \r\n- Tomasz Novak (Deckhand)  \r\n- Leo Sánchez (Cook)  \r\n- Eli Grayson (Mechanic)  \r\n- Ryan Jacobs (Medic)\r\n\r\n**Cargo Summary:**  \r\n- Total Pallets: 70  \r\n- Total Weight: 22,500 kg  \r\n\r\n**Detailed Cargo Breakdown:**\r\n\r\n1. **Insulin Shipment:**  \r\n   - 49 pallets  \r\n   - Weight: 17,640 kg  \r\n   - Description: 49 pallets of temperature-sensitive insulin, to be delivered to various medical facilities in São Paulo. Each pallet is securely packed in temperature-controlled containers designed to maintain a constant range of 2-8°C, ensuring the pharmaceutical product’s integrity during the oceanic voyage.  \r\n   - Special Handling: Constant monitoring of the container’s temperature. Chief Mate Marlow will oversee hourly temperature logs and report any anomalies directly to the Captain.\r\n\r\n2. **Medical Equipment:**  \r\n   - 15 pallets  \r\n   - Weight: 3,500 kg  \r\n   - Description: Various hospital-grade equipment, including dialysis machines, IV stands, and ventilators, intended for distribution across healthcare facilities in São Paulo.\r\n\r\n3. **Emergency Food Supplies:**  \r\n   - 6 pallets  \r\n   - Weight: 1,360 kg  \r\n   - Description: Pre-packaged non-perishable food items to be distributed to relief centers in São Paulo. These goods are stored in standard refrigerated containers but do not require constant monitoring.\r\n\r\n**Special Instructions:**  \r\nDue to the value and sensitivity of the cargo, all temperature-controlled containers are marked with priority status and require immediate offloading upon arrival in São Paulo.";
        string shadowmanifest = "Client: Biotechnica\r\nPurpose: Covert biological material transport\r\n\r\nUnlisted Cargo – Experimental Biotech Materials:\r\n\r\n6 concealed crates, embedded within the insulin shipment.\r\nContents: Classified. Believed to be genetically modified pathogens and experimental biological agents developed by Biotechnica for use in clandestine research and human testing. These pathogens are disguised within temperature-controlled pallets, ensuring their integrity during the voyage.\r\nDestination: São Paulo black site facility, covertly managed by Biotechnica for the purpose of illegal bioweapon research and genetic experimentation.\r\nCrew Awareness:\r\n\r\nCaptain Alexander Cortez is complicit in the operation and has been paid off to ensure smooth delivery. First Officer Naomi Rivera and Chief Engineer Javier Silva are also involved in maintaining the false logs and ensuring the concealed cargo goes undetected by local authorities.\r\nStrategic Goal (speculative): \r\n\r\nBiotechnica aims to establish a foothold in São Paulo's underground biotech market, using these shipments to further develop advanced biological weapons for future sale to private military contractors and authoritarian regimes. The success of this covert operation will significantly bolster Biotechnica's global dominance in the illicit biotech sector.\r\nOperational Cover:\r\nThe insulin and medical supplies are legitimate to deflect suspicion.";
            string techspecs = "Technical Specifications: Cooling and Environmental Management System\r\n\r\nThe cooling system employed in this unit utilizes an advanced cryogenic-based refrigeration method, designed to maintain operational stability in environments with high energy outputs. Integrated thermoelectric sensors monitor ambient temperatures, with the system set to an optimal cooling rate of 5 degrees Celsius as the standard default setting. A network of microfluidic channels circulates synthetic coolant through graphene heat sinks, maximizing thermal dissipation while ensuring minimal energy consumption.\r\n\r\nThis system is built with redundancy features to prevent overheating under extreme loads. If the system detects a temperature rise beyond 7 degrees Celsius, the fail-safe protocol activates automatically. A multi-tiered alert system triggers, sending an immediate notification to the manufacturing team via encrypted cloud communication, as well as alerting the owners through a dedicated signal uplink.\r\n\r\nEnergy efficiency is critical in this cyberpunk world; therefore, this unit operates using a quantum dot-enabled power regulator, which dynamically adjusts power distribution based on current temperature readings. The AI management core continuously analyzes environmental conditions, rerouting excess energy away from non-critical operations to ensure uninterrupted cooling functionality.\r\n\r\nThe system's architecture supports remote diagnostics, allowing the manufacturer and owners to inspect operational performance in real time through a secure interface, enhancing reliability. The alarm protocol is linked directly to the central mainframe, providing diagnostic codes and suggesting corrective actions if necessary. In case of a critical failure, the cooling system will autonomously throttle down non-essential processes to maintain the core at a manageable temperature, even during maintenance delays.\r\n\r\nThis infrastructure ensures continuous performance even under the harshest conditions common in cyberpunk urban sprawl, with a focus on mitigating risk in high-stress, high-energy environments.";

        public virtual void Use()
        {
            Console.WriteLine("Using your Crystal Ball you gain access to the working monitor of the ship.");
            Console.WriteLine("*Please say out loud: \"I'm IN!\", in the most hackerlike way you can.*");
            int temp = 5;

            for (int i = 0; i < 10; i++)
            {

            Console.WriteLine("You have limited time: " + (10-i));
            Console.WriteLine("Menu");
            Console.WriteLine("1: Cooling System Control");
            Console.WriteLine("2: Manifest.txt");
            Console.WriteLine("3: *SeeYa* Manifest_invisi.txt");
            Console.WriteLine("4: Exit");


            int cho = int.Parse(Console.ReadLine());

                switch (cho)
                {
                    case 1:



                        Console.WriteLine("CoolDude 3000");
                        Console.WriteLine("Advisement: Offsite Security Set. See documentation");
                        Console.WriteLine("Current Target Temperature: "  +temp);
                        Console.WriteLine();
                        Console.WriteLine("Options:");
                        Console.WriteLine("1: Set Temperature");
                        Console.WriteLine("2: Cooling system Documentation");
                        Console.WriteLine("3: Back");
                        int cho2 = int.Parse(Console.ReadLine());
                        switch (cho2)
                        {
                            case 1:
                                Console.WriteLine("Target temperature: (-20 to 23 C)");
                         temp = int.Parse(Console.ReadLine());
                                Console.WriteLine("Target temperature set to " + temp);
                                if (temp>7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(  "Alert! Illegal parameter set: Offsite security alerted.");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                Console.WriteLine();
                                Console.WriteLine();

                                break;

                            case 2:
                                Console.WriteLine(techspecs);
                                Console.WriteLine();
                                break;
                            case 3:
                           

                                break;
                            default:
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine(manifest);
                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                    case 3:
                        Console.WriteLine(shadowmanifest);
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case 4:
                        i = 11;
                        break;
                    default:
                        break;
                }

            }

        }
    }

    

}


