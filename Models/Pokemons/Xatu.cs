using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Xatu Specie to store common natural stats of all Xatus
	#region SpecieXatu
	public class SpecieXatu : PokemonSpecie
	{
#nullable enable
		private static SpecieXatu? _instance = null;
#nullable restore
        public static SpecieXatu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXatu();
                }
                return _instance;
            }
        }

		#region SpecieXatu Builder
		public SpecieXatu() : base(
			"Xatu",
			65, // HPs
			75, 70, // Attack & Defense
			95, 70, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Xatu Pokemon Class
	#region Xatu
	public class Xatu : Pokemon
	{
		#region Xatu Builders
		/// <summary>
		/// Xatu Builder waiting for a Nickname & a Level
		/// </summary>
		public Xatu(string nickname, int level)
		: base(
				178,
				SpecieXatu.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Builder only waiting for a Level
		/// </summary>
		public Xatu(int level)
		: base(
				178,
				SpecieXatu.Instance, // Pokemon Specie
				"Xatu", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Xatu() : base(
			178,
			SpecieXatu.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}