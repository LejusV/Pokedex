using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bergmite Specie to store common natural stats of all Bergmites
	#region SpecieBergmite
	public class SpecieBergmite : PokemonSpecie
	{
#nullable enable
		private static SpecieBergmite? _instance = null;
#nullable restore
        public static SpecieBergmite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBergmite();
                }
                return _instance;
            }
        }

		#region SpecieBergmite Builder
		public SpecieBergmite() : base(
			"Bergmite",
			55, // HPs
			69, 85, // Attack & Defense
			32, 35, // Special Attack & Defense
			28		
		)
		{
			this._height = 10;
			this._weight = 995;
		}
		#endregion
	}
	#endregion

	//Bergmite Pokemon Class
	#region Bergmite
	public class Bergmite : Pokemon
	{
		#region Bergmite Builders
		/// <summary>
		/// Bergmite Builder waiting for a Nickname & a Level
		/// </summary>
		public Bergmite(string nickname, int level)
		: base(
				712,
				SpecieBergmite.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Builder only waiting for a Level
		/// </summary>
		public Bergmite(int level)
		: base(
				712,
				SpecieBergmite.Instance, // Pokemon Specie
				"Bergmite", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bergmite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bergmite() : base(
			712,
			SpecieBergmite.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}