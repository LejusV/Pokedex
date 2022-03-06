using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Boldore Specie to store common natural stats of all Boldores
	#region SpecieBoldore
	public class SpecieBoldore : PokemonSpecie
	{
#nullable enable
		private static SpecieBoldore? _instance = null;
#nullable restore
        public static SpecieBoldore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBoldore();
                }
                return _instance;
            }
        }

		#region SpecieBoldore Builder
		public SpecieBoldore() : base(
			"Boldore",
			70, // HPs
			105, 105, // Attack & Defense
			50, 40, // Special Attack & Defense
			20		
		)
		{
			this._height = 9;
			this._weight = 1020;
		}
		#endregion
	}
	#endregion

	//Boldore Pokemon Class
	#region Boldore
	public class Boldore : Pokemon
	{
		#region Boldore Builders
		/// <summary>
		/// Boldore Builder waiting for a Nickname & a Level
		/// </summary>
		public Boldore(string nickname, int level)
		: base(
				525,
				SpecieBoldore.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Builder only waiting for a Level
		/// </summary>
		public Boldore(int level)
		: base(
				525,
				SpecieBoldore.Instance, // Pokemon Specie
				"Boldore", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Boldore Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Boldore() : base(
			525,
			SpecieBoldore.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}