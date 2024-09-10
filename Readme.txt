Circle World Creator Documentation

Circle World Creator (or CWC) is a Windows .NET application written in
MS Visual C#.  It is customizable and fully compatible with the
CircleMUD 3.x world format.  CWC uses a text-based configuration file
to allow customization and adaptation to new world file formats.

CWC is (currently) in Public Beta mode and needs testing.  The author
(me) feels that care should be used in the usage of this program and
frequent backups of world files (even those not manipulated by this
program) should be done to reduce the possiblility of data loss.  I
cannot be held responsible for any damage, either to data or physical
property caused by the usage of this program or any other.  That said,
enjoy this program and I'd welcome any feedback whatsoever.

This is my first program written entirely in MS Visual C# and using
the Windows .NET platform.  As such, there will probably be many
revisions to this and future programs that I release.

Circle Wold Creator (as of version 2.5) is released under Version 2 of
the GNU Public License.  For details, see the file 'Lisense.txt'
included in this package or browse to:
http://www.gnu.org/licenses/gpl.html
----------------------------------------------------------------------
NOTE: Circle World Creator REQUIRES the Microsoft .NET Platform in
order to run.

Microsoft .NET Platform Download Locations:

MS .NET Platform 1.0 (English)
http://download.microsoft.com/download/.netframesdk/Redist/1.0/
W98NT42KMeXP/EN-US/dotnetredist.exe

MS .NET Platform Sevice Pack 2 (English)
http://download.microsoft.com/download/NETFrameworkRedistributable/
Patch/2/W98NT42KMeXP/EN-US/NDP10_SP_Q321884_En.exe

For other languages, check out the main .NET Download page:
http://msdn.microsoft.com/netframework/downloads/

MS .NET Platform 1.1 should also work fine.
----------------------------------------------------------------------
Current Download Locations:

http://home.comcast.net/~silvertower/cwc/CWCSetup.exe
ftp://ftp.circlemud.org/pub/CircleMUD/contrib/windows/Programs/
CWCSetup.exe
----------------------------------------------------------------------
Program Information:

CWC automatically loads 'Default.mudcfg' at startup which sets CWC's
internal properties to comply with the CircleMUD 3.x world format.
After program launch, a different configuration may be loaded by
selecting 'Tools/Load MUD Configuration' and loading a different
configuration (all CWC MUD configuration files end with .mudcfg).  To
make a custom configuration file load automatically at program
startup, simply rename 'Default.mudcfg' and rename the custom MUD
configuration file to 'Default.mudcfg'.

Information on the mudcfg file format can be found in the file
'mudcfg.txt'.  Please note that the "real" mudcfg files do not
(currently) support comments as shown in 'mudcfg.txt'.

Note: Opening "Entire Areas" require that the world files be stored in
the EXACT same folder format as CircleMUD 3.x files are stored in the
'lib/world' folders.  (ie. mob/, obj/, shp/, wld/, zon/ must exist and
be in the same parent directory).
----------------------------------------------------------------------
Program Limitations:

Currently Error/Exception handling is not handled in a very elegant
way.  As such, if CWC encounters a major error, it may crash and
unsaved data may be lost.  In later versions I will explore the
possibility of incorporating auto-save and data recovery features.
----------------------------------------------------------------------
About the Author:

My name is Alan K. Miles and I am (currently) living in Eugene, OR,
USA where I have completed my BS in Computer and Information Science
at the University of Oregon.  I spend a good deal of my time
programming and using/building computers and am always exploring new
languages and programming techniques.  I can be reached through e-mail
at:

silvertower@comcast.net
