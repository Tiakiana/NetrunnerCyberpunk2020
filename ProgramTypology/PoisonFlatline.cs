namespace NetrunnerConsole.ProgramTypology
{
    public class PoisonFlatline : NetProgram
    {
        public PoisonFlatline(string name, int mU, int programStrength, Area area, NetSystem mySystem, Deck deck) : base(name, mU, programStrength, area, mySystem, deck)
        {

        }

        public override void Activate()
        {

            int attack = RNG.D10;
            int defenceroll = RNG.D10;

            Console.WriteLine($"The Poison Flatline prog beams towards you with a memory poisoning green light: [(roll){attack} + (programstrength) {ProgramStrength}]");
            Console.WriteLine($"You defend yourself as best you can! [(roll) {defenceroll} + (datawall strength) {Player.inst.CurrentDeckEquipped.DatawallStrength}");


            if (attack + ProgramStrength >= defenceroll + Player.inst.CurrentDeckEquipped.DatawallStrength)
            {
                Console.WriteLine("Your majesty! Our braina IT'S A MEEE MARIO izzzz dduuuuuuuuuurr rrrrrrrr");

                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.WriteLine(".......----.........");
                Thread.Sleep(1000);
                Console.WriteLine("Wahuuu!");
                Thread.Sleep(1000);
                Console.WriteLine("!#!%!%¤#%¤ /%¤/%&%&/%¤");
                Thread.Sleep(1000);

                Console.WriteLine("Deck Wrecked");
                Console.WriteLine("\r\n                             __xxxxxxxxxxxxxxxx___.\r\n                        _gxXXXXXXXXXXXXXXXXXXXXXXXX!x_\r\n                   __x!XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!x_\r\n                ,gXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx_\r\n              ,gXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!_\r\n            _!XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!.\r\n          gXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXs\r\n        ,!XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!.\r\n       g!XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n      iXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n     ,XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx\r\n     !XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx\r\n   ,XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx\r\n   !XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXi\r\n  dXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n  !XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX\r\n   XXXXXXXXXXXXXXXXXXXf~~~VXXXXXXXXXXXXXXXXXXXXXXXXXXvvvvvvvvXXXXXXXXXXXXXX!\r\n   !XXXXXXXXXXXXXXXf`       'XXXXXXXXXXXXXXXXXXXXXf`          '~XXXXXXXXXXP\r\n    vXXXXXXXXXXXX!            !XXXXXXXXXXXXXXXXXX!              !XXXXXXXXX\r\n     XXXXXXXXXXv`              'VXXXXXXXXXXXXXXX                !XXXXXXXX!\r\n     !XXXXXXXXX.                 YXXXXXXXXXXXXX!                XXXXXXXXX\r\n      XXXXXXXXX!                 ,XXXXXXXXXXXXXX                VXXXXXXX!\r\n      'XXXXXXXX!                ,!XXXX ~~XXXXXXX               iXXXXXX~\r\n       'XXXXXXXX               ,XXXXXX   XXXXXXXX!             xXXXXXX!\r\n        !XXXXXXX!xxxxxxs______xXXXXXXX   'YXXXXXX!          ,xXXXXXXXX\r\n         YXXXXXXXXXXXXXXXXXXXXXXXXXXX`    VXXXXXXX!s. __gxx!XXXXXXXXXP\r\n          XXXXXXXXXXXXXXXXXXXXXXXXXX!      'XXXXXXXXXXXXXXXXXXXXXXXXX!\r\n          XXXXXXXXXXXXXXXXXXXXXXXXXP        'YXXXXXXXXXXXXXXXXXXXXXXX!\r\n          XXXXXXXXXXXXXXXXXXXXXXXX!     i    !XXXXXXXXXXXXXXXXXXXXXXXX\r\n          XXXXXXXXXXXXXXXXXXXXXXXX!     XX   !XXXXXXXXXXXXXXXXXXXXXXXX\r\n          XXXXXXXXXXXXXXXXXXXXXXXXx_   iXX_,_dXXXXXXXXXXXXXXXXXXXXXXXX\r\n          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXP\r\n          XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n           ~vXvvvvXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXf\r\n                    'VXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXvvvvvv~\r\n                      'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX~\r\n                  _    XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXv`\r\n                 -XX!  !XXXXXXX~XXXXXXXXXXXXXXXXXXXXXX~   Xxi\r\n                  YXX  '~ XXXXX XXXXXXXXXXXXXXXXXXXX`     iXX`\r\n                  !XX!    !XXX` XXXXXXXXXXXXXXXXXXXX      !XX\r\n                  !XXX    '~Vf  YXXXXXXXXXXXXXP YXXX     !XXX\r\n                  !XXX  ,_      !XXP YXXXfXXXX!  XXX     XXXV\r\n                  !XXX !XX           'XXP 'YXX!       ,.!XXX!\r\n                  !XXXi!XP  XX.                  ,_  !XXXXXX!\r\n                  iXXXx X!  XX! !Xx.  ,.     xs.,XXi !XXXXXXf\r\n                   XXXXXXXXXXXXXXXXX! _!XXx  dXXXXXXX.iXXXXXX\r\n                   VXXXXXXXXXXXXXXXXXXXXXXXxxXXXXXXXXXXXXXXX!\r\n                   YXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXV\r\n                    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX!\r\n                    'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXf\r\n                       VXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXf\r\n                         VXXXXXXXXXXXXXXXXXXXXXXXXXXXXv`\r\n                          ~vXXXXXXXXXXXXXXXXXXXXXXXf`\r\n                              ~vXXXXXXXXXXXXXXXXv~\r\n                                 '~VvXXXXXXXV~~\r\n                                       ~~\r\n\r\n                              __\r\n                              XX\r\n_________        ______       ~~     _______         ______      ___.    ___.\r\nXXXXXXXXX.     ,gXXXXXX.      XX    ,XXXXXXXs      ,gXXXXXX.     XXXi    XXX\r\nXXXXXXXXXX.  ,dXXXXXXXXXs     XX   iXXXXXXXXXi    iXXXXXXXXXX_   XXXb    XXX\r\nXXX~~~XXXXX  XXXXX~ ~~XXXX.   XX  XXXX~   XXXX   iXXXX~`'~XXXXi  XXXXs   XXX\r\nXXX    dXXX  XXX       XXXX   XX  XXXXXs_  '~~   XXX`      XXXX  XXXXXb !XXX\r\nXXX___XXXXX iXXX!       XXX   XX   XXXXXXXXXs   iXXX        XXX  XXX XXi XXX\r\nXXXXXXXXXX`  XXX.       XXX   XX    ~XXXXXXXXX   XXX        XXX  XXX'XXX XXX\r\nXXXXXXXXX`   XXX       XXXX   XX  ____ '~XXXXXb  XXX       XXXX  XXX !XXbXXX\r\nXXX          XXXb     gXXX!   XX  XXXX      XXX  XXXb     gXXX   XXX  'XXXXX\r\nXXX          XXXXXXXXXXXXf    XX  ~XXXXX_gXXXX!  'XXXXXXXXXXXX`  XXX   !XXXX\r\nXXX           ~XXXXXXXXX`     XX    XXXXXXXXX~    'XXXXXXXXX`    XXX    XXXX\r\n~~~              ~~X~~`      '~~`     XXXXX~         ~~X~~`      ~~~    '~~~`\r\n                   ~                  ~~~~~            ~");

                Player.inst.CurrentDeckEquipped.Destroyed = true;

            }

        }


    }

}
