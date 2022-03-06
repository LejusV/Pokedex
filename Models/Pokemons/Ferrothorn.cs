using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ferrothorn Specie to store common natural stats of all Ferrothorns
	#region SpecieFerrothorn
	public class SpecieFerrothorn : PokemonSpecie
	{
#nullable enable
		private static SpecieFerrothorn? _instance = null;
#nullable restore
        public static SpecieFerrothorn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFerrothorn();
                }
                return _instance;
            }
        }

		#region SpecieFerrothorn Builder
		public SpecieFerrothorn() : base(
			"Ferrothorn",
			1.0,
			110.0,
			74, // HPs
			94, 131, // Attack & Defense
			54, 116, // Special Attack & Defense
			20		
		)
		{}
		#endregion
	}
	#endregion

	//Ferrothorn Pokemon Class
	#region Ferrothorn
	public class Ferrothorn : Pokemon
	{
		#region Ferrothorn Builders
		/// <summary>
		/// Ferrothorn Builder waiting for a Nickname & a Level
		/// </summary>
		public Ferrothorn(string nickname, int level)
		: base(
				598,
				SpecieFerrothorn.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Builder only waiting for a Level
		/// </summary>
		public Ferrothorn(int level)
		: base(
				598,
				SpecieFerrothorn.Instance, // Pokemon Specie
				"Ferrothorn", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ferrothorn Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ferrothorn() : base(
			598,
			SpecieFerrothorn.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}