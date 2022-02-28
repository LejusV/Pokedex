using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vileplume Specie to store common natural stats of all Vileplumes
	#region SpecieVileplume
	public class SpecieVileplume : PokemonSpecie
	{
#nullable enable
		private static SpecieVileplume? _instance = null;
#nullable restore
        public static SpecieVileplume Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVileplume();
                }
                return _instance;
            }
        }

		#region SpecieVileplume Builder
		public SpecieVileplume() : base(
			"Vileplume",
			75, // HPs
			80, 85, // Attack & Defense
			110, 90, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Vileplume Pokemon Class
	#region Vileplume
	public class Vileplume : Pokemon
	{
		#region Vileplume Builders
		/// <summary>
		/// Vileplume Builder waiting for a Nickname & a Level
		/// </summary>
		public Vileplume(string nickname, int level)
		: base(
				45,
				SpecieVileplume.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Builder only waiting for a Level
		/// </summary>
		public Vileplume(int level)
		: base(
				45,
				SpecieVileplume.Instance, // Pokemon Specie
				"Vileplume", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vileplume Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Vileplume() : base(
			45,
			SpecieVileplume.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}