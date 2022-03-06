using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Porygon-Z Specie to store common natural stats of all Porygon-Zs
	#region SpeciePorygon-Z
	public class SpeciePorygonZ : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygonZ? _instance = null;
#nullable restore
        public static SpeciePorygonZ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygonZ();
                }
                return _instance;
            }
        }

		#region SpeciePorygon-Z Builder
		public SpeciePorygonZ() : base(
			"Porygon-Z",
			85, // HPs
			80, 70, // Attack & Defense
			135, 75, // Special Attack & Defense
			90		
		)
		{
			this._height = 9;
			this._weight = 340;
		}
		#endregion
	}
	#endregion

	//Porygon-Z Pokemon Class
	#region Porygon-Z
	public class PorygonZ : Pokemon
	{
		#region Porygon-Z Builders
		/// <summary>
		/// Porygon-Z Builder waiting for a Nickname & a Level
		/// </summary>
		public PorygonZ(string nickname, int level)
		: base(
				474,
				SpeciePorygonZ.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Builder only waiting for a Level
		/// </summary>
		public PorygonZ(int level)
		: base(
				474,
				SpeciePorygonZ.Instance, // Pokemon Specie
				"Porygon-Z", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon-Z Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public PorygonZ() : base(
			474,
			SpeciePorygonZ.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}