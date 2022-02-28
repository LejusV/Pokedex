using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Slurpuff Specie to store common natural stats of all Slurpuffs
	#region SpecieSlurpuff
	public class SpecieSlurpuff : PokemonSpecie
	{
#nullable enable
		private static SpecieSlurpuff? _instance = null;
#nullable restore
        public static SpecieSlurpuff Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSlurpuff();
                }
                return _instance;
            }
        }

		#region SpecieSlurpuff Builder
		public SpecieSlurpuff() : base(
			"Slurpuff",
			82, // HPs
			80, 86, // Attack & Defense
			85, 75, // Special Attack & Defense
			72			
		) {}
		#endregion
	}
	#endregion

	//Slurpuff Pokemon Class
	#region Slurpuff
	public class Slurpuff : Pokemon
	{
		#region Slurpuff Builders
		/// <summary>
		/// Slurpuff Builder waiting for a Nickname & a Level
		/// </summary>
		public Slurpuff(string nickname, int level)
		: base(
				685,
				SpecieSlurpuff.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Builder only waiting for a Level
		/// </summary>
		public Slurpuff(int level)
		: base(
				685,
				SpecieSlurpuff.Instance, // Pokemon Specie
				"Slurpuff", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Slurpuff Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Slurpuff() : base(
			685,
			SpecieSlurpuff.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}