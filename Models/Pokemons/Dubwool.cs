using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dubwool Specie to store common natural stats of all Dubwools
	#region SpecieDubwool
	public class SpecieDubwool : PokemonSpecie
	{
#nullable enable
		private static SpecieDubwool? _instance = null;
#nullable restore
        public static SpecieDubwool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDubwool();
                }
                return _instance;
            }
        }

		#region SpecieDubwool Builder
		public SpecieDubwool() : base(
			"Dubwool",
			1.3,
			43.0,
			72, // HPs
			80, 100, // Attack & Defense
			60, 90, // Special Attack & Defense
			88		
		)
		{}
		#endregion
	}
	#endregion

	//Dubwool Pokemon Class
	#region Dubwool
	public class Dubwool : Pokemon
	{
		#region Dubwool Builders
		/// <summary>
		/// Dubwool Builder waiting for a Nickname & a Level
		/// </summary>
		public Dubwool(string nickname, int level)
		: base(
				832,
				SpecieDubwool.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Builder only waiting for a Level
		/// </summary>
		public Dubwool(int level)
		: base(
				832,
				SpecieDubwool.Instance, // Pokemon Specie
				"Dubwool", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dubwool Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dubwool() : base(
			832,
			SpecieDubwool.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}