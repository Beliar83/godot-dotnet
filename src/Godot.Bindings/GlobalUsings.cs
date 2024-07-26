#if REAL_T_IS_DOUBLE
global using real_t = double;
#else
global using real_t = float;
#endif
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("FSXScript.Editor")]
