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
        public NetSystem System = new NetSystem();

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


        static void Main(string[] args)
        {
            Console.SetWindowSize(145, 50);
            Console.ForegroundColor
        = ConsoleColor.Red;

            Console.WriteLine(ascified);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("All Hail the Majestic Regina! How can thy serfs help thee?");

            Program p = new Program();
            p.Player.CurrentDeckEquipped = new Deck();
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateWizardsBook(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateInvisibility(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateStealth(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateForceProtection(p.Player.CurrentDeckEquipped));
            p.Player.CurrentDeckEquipped.ProgramList.Add(NetProgram.CreateKiller4(p.Player.CurrentDeckEquipped));

            p.Player.Area = p.System.Areas[0];
            p.Player.Team = 3;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Your Command, thy Majesty?");

                string res = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                res = res.ToUpper();
                switch (res)
                {
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
                        if (Player.inst.ActivePrograms.Count == 0)
                        {
                            Console.WriteLine(  "Naught and nothing");
                        }
                        else
                        {

                            foreach (var item in Player.inst.ActivePrograms)
                            {
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
                        Console.WriteLine("Look: scans your immediate surroundings");
                        Console.WriteLine("Read read a file in same area or in your deck.");
                        Console.WriteLine("Erase");
                        Console.WriteLine("Clear: *new*");
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

                        Console.WriteLine("You look around.\nYou are at: ");
                        Console.WriteLine(p.Player.Area.Scan(p.Player));
                        Console.WriteLine();
                        Console.WriteLine();

                        break;

                    case "":
                        Console.WriteLine("No input detected. Are you a moron?");
                        break;
                    case "CLEAR":
                        Console.Clear();
                        Console.WriteLine("Tidying up for Thee, Your Majesty");
                        break;
                }
            }
        }

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

            for (int ix = 1; ix < Player.inst.Area.Gates.Count + 1; ix++)
            {
                // Console.WriteLine(ix + ": " + Player.inst.Area.Gates[ix - 1].GateName);
                Console.WriteLine(ix + ": " + (Player.inst.Area.Gates[ix - 1].GetName(Player.inst.Area)));
                // Player.Area.Gates[ix - 1].Inside == Player.Area ? Player.Area.Gates[ix-1].OutSide.Name: Player.Area.Gates[ix - 1].Inside.Name));

            }

            int res2 = int.Parse(Console.ReadLine());
            res2--;
            return Player.inst.Area.Gates[res2];
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
}


