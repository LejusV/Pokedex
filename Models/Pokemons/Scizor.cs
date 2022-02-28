using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scizor Specie to store common natural stats of all Scizors
	#region SpecieScizor
	public class SpecieScizor : PokemonSpecie
	{
#nullable enable
		private static SpecieScizor? _instance = null;
#nullable restore
        public static SpecieScizor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScizor();
                }
                return _instance;
            }
        }

		#region SpecieScizor Builder
		public SpecieScizor() : base(
			"Scizor",
			70, // HPs
			130, 100, // Attack & Defense
			55, 80, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Scizor Pokemon Class
	#region Scizor
	public class Scizor : Pokemon
	{
		#region Scizor Builders
		/// <summary>
		/// Scizor Builder waiting for a Nickname & a Level
		/// </summary>
		public Scizor(string nickname, int level)
		: base(
				212,
				SpecieScizor.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Builder only waiting for a Level
		/// </summary>
		public Scizor(int level)
		: base(
				212,
				SpecieScizor.Instance, // Pokemon Specie
				"Scizor", level,
				Bug.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Scizor() : base(
			212,
			SpecieScizor.Instance, // Pokemon Specie
			Bug.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}