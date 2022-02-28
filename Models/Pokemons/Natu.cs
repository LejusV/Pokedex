using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Natu Specie to store common natural stats of all Natus
	#region SpecieNatu
	public class SpecieNatu : PokemonSpecie
	{
#nullable enable
		private static SpecieNatu? _instance = null;
#nullable restore
        public static SpecieNatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNatu();
                }
                return _instance;
            }
        }

		#region SpecieNatu Builder
		public SpecieNatu() : base(
			"Natu",
			40, // HPs
			50, 45, // Attack & Defense
			70, 45, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Natu Pokemon Class
	#region Natu
	public class Natu : Pokemon
	{
		#region Natu Builders
		/// <summary>
		/// Natu Builder waiting for a Nickname & a Level
		/// </summary>
		public Natu(string nickname, int level)
		: base(
				177,
				SpecieNatu.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Builder only waiting for a Level
		/// </summary>
		public Natu(int level)
		: base(
				177,
				SpecieNatu.Instance, // Pokemon Specie
				"Natu", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Natu() : base(
			177,
			SpecieNatu.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}