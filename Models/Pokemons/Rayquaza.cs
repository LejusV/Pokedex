using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rayquaza Specie to store common natural stats of all Rayquazas
	#region SpecieRayquaza
	public class SpecieRayquaza : PokemonSpecie
	{
#nullable enable
		private static SpecieRayquaza? _instance = null;
#nullable restore
        public static SpecieRayquaza Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRayquaza();
                }
                return _instance;
            }
        }

		#region SpecieRayquaza Builder
		public SpecieRayquaza() : base(
			"Rayquaza",
			7.0,
			206.5,
			105, // HPs
			150, 90, // Attack & Defense
			150, 90, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Rayquaza Pokemon Class
	#region Rayquaza
	public class Rayquaza : Pokemon
	{
		#region Rayquaza Builders
		/// <summary>
		/// Rayquaza Builder waiting for a Nickname & a Level
		/// </summary>
		public Rayquaza(string nickname, int level)
		: base(
				384,
				SpecieRayquaza.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Builder only waiting for a Level
		/// </summary>
		public Rayquaza(int level)
		: base(
				384,
				SpecieRayquaza.Instance, // Pokemon Specie
				"Rayquaza", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rayquaza Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rayquaza() : base(
			384,
			SpecieRayquaza.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}