using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Relicanth Specie to store common natural stats of all Relicanths
	#region SpecieRelicanth
	public class SpecieRelicanth : PokemonSpecie
	{
#nullable enable
		private static SpecieRelicanth? _instance = null;
#nullable restore
        public static SpecieRelicanth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRelicanth();
                }
                return _instance;
            }
        }

		#region SpecieRelicanth Builder
		public SpecieRelicanth() : base(
			"Relicanth",
			1.0,
			23.4,
			100, // HPs
			90, 130, // Attack & Defense
			45, 65, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Relicanth Pokemon Class
	#region Relicanth
	public class Relicanth : Pokemon
	{
		#region Relicanth Builders
		/// <summary>
		/// Relicanth Builder waiting for a Nickname & a Level
		/// </summary>
		public Relicanth(string nickname, int level)
		: base(
				369,
				SpecieRelicanth.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Builder only waiting for a Level
		/// </summary>
		public Relicanth(int level)
		: base(
				369,
				SpecieRelicanth.Instance, // Pokemon Specie
				"Relicanth", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Relicanth Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Relicanth() : base(
			369,
			SpecieRelicanth.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}