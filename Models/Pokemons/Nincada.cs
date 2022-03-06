using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nincada Specie to store common natural stats of all Nincadas
	#region SpecieNincada
	public class SpecieNincada : PokemonSpecie
	{
#nullable enable
		private static SpecieNincada? _instance = null;
#nullable restore
        public static SpecieNincada Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNincada();
                }
                return _instance;
            }
        }

		#region SpecieNincada Builder
		public SpecieNincada() : base(
			"Nincada",
			0.5,
			5.5,
			31, // HPs
			45, 90, // Attack & Defense
			30, 30, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Nincada Pokemon Class
	#region Nincada
	public class Nincada : Pokemon
	{
		#region Nincada Builders
		/// <summary>
		/// Nincada Builder waiting for a Nickname & a Level
		/// </summary>
		public Nincada(string nickname, int level)
		: base(
				290,
				SpecieNincada.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Builder only waiting for a Level
		/// </summary>
		public Nincada(int level)
		: base(
				290,
				SpecieNincada.Instance, // Pokemon Specie
				"Nincada", level,
				Bug.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nincada Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nincada() : base(
			290,
			SpecieNincada.Instance, // Pokemon Specie
			Bug.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}