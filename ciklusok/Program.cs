using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 3. CIKLUS (iteráció)

			/* Olyan vezérlési szerkezet, amelyben egy adott műveletsort (ciklusmag) addig kell ismételni, amíg egy adott feltétel (ciklusfeltétel) teljesül.
			 * a) számlálós ciklus
			 *	Használata: pontosan tudjuk, hogy az adott műveletsort hányszor akarjuk megismételni.
			 *	Algoritmus:
			 *		Ciklus i := kezdőértéktől végértékig
			 *			ciklusmag
			 *		Ciklus vége
			 *	
			 *		C#
			 *		for (kezdőértéke; feltétel; lépésszám) {
			 *			ciklusmag;
			 *		}
			 *	Példa: Írjuk ki a számokat 1-től 10-ig!
			 *	Ciklus i := 1-től 10-ig
			 *		Ki: i
			 *	Ciklus vége
			 */
			for (int i = 1; i <= 10; i++)
				Console.WriteLine(i);

			Console.WriteLine();
			/* Ciklus i := 1-től 10-ig 2-vel
			 *	Ki: i
			 * Ciklus vége
			 */
			for (int i = 1; i <= 10;i+=2)
				Console.WriteLine(i);

			Console.WriteLine();
			/* Ciklus i:= 10-től 1-ig 1-el
			 *	Ki: i
			 * Ciklus vége
			 */
			for (int i = 10; i >= 1; i--)
				Console.WriteLine(i);
			Console.WriteLine();


			// ELÖLTESZTELŐS CIKLUS

			/* A ciklusmagot csak a ciklusfeltétel teljesülése esetén hajtjuk végre.
			 * 
			 * Algoritmus:
			 *	Ciklus amíg feltétel
			 *		ciklusmag
			 *	Ciklus vége
			 *	
			 *	C#
			 *	kezdőérték;
			 *	while (feltétel) {
			 *		ciklusmag;
			 *		lépésszám;
			 *	}
			 *	
			 *	Példa: Írjuk ki a számokat 1-től 10-ig!
			 *	i := 1
			 *	Ciklus amíg (i <= 10)
			 *		Ki: i
			 *		i := i + 1
			 *	Ciklus vége
			 */

			int j = 1;
			while (j <= 10)
			{
				Console.WriteLine(j);
				j++;
			}
		}
	}
}
