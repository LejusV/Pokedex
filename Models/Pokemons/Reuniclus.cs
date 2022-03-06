using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Reuniclus Specie to store common natural stats of all Reunicluss
	#region SpecieReuniclus
	public class SpecieReuniclus : PokemonSpecie
	{
#nullable enable
		private static SpecieReuniclus? _instance = null;
#nullable restore
        public static SpecieReuniclus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieReuniclus();
                }
                return _instance;
            }
        }

		#region SpecieReuniclus Builder
		public SpecieReuniclus() : base(
			"Reuniclus",
			110, // HPs
			65, 75, // Attack & Defense
			125, 85, // Special Attack & Defense
			30		
		)
		{
			this._height = 10;
			this._weight = 201;
		}
		#endregion
	}
	#endregion

	//Reuniclus Pokemon Class
	#region Reuniclus
	public class Reuniclus : Pokemon
	{
		#region Reuniclus Builders
		/// <summary>
		/// Reuniclus Builder waiting for a Nickname & a Level
		/// </summary>
		public Reuniclus(string nickname, int level)
		: base(
				579,
				SpecieReuniclus.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Builder only waiting for a Level
		/// </summary>
		public Reuniclus(int level)
		: base(
				579,
				SpecieReuniclus.Instance, // Pokemon Specie
				"Reuniclus", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Reuniclus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Reuniclus() : base(
			579,
			SpecieReuniclus.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}