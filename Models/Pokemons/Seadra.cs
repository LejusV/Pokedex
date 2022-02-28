using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seadra Specie to store common natural stats of all Seadras
	#region SpecieSeadra
	public class SpecieSeadra : PokemonSpecie
	{
#nullable enable
		private static SpecieSeadra? _instance = null;
#nullable restore
        public static SpecieSeadra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeadra();
                }
                return _instance;
            }
        }

		#region SpecieSeadra Builder
		public SpecieSeadra() : base(
			"Seadra",
			55, // HPs
			65, 95, // Attack & Defense
			95, 45, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Seadra Pokemon Class
	#region Seadra
	public class Seadra : Pokemon
	{
		#region Seadra Builders
		/// <summary>
		/// Seadra Builder waiting for a Nickname & a Level
		/// </summary>
		public Seadra(string nickname, int level)
		: base(
				117,
				SpecieSeadra.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Builder only waiting for a Level
		/// </summary>
		public Seadra(int level)
		: base(
				117,
				SpecieSeadra.Instance, // Pokemon Specie
				"Seadra", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Seadra() : base(
			117,
			SpecieSeadra.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}