using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Armaldo Specie to store common natural stats of all Armaldos
	#region SpecieArmaldo
	public class SpecieArmaldo : PokemonSpecie
	{
#nullable enable
		private static SpecieArmaldo? _instance = null;
#nullable restore
        public static SpecieArmaldo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArmaldo();
                }
                return _instance;
            }
        }

		#region SpecieArmaldo Builder
		public SpecieArmaldo() : base(
			"Armaldo",
			75, // HPs
			125, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Armaldo Pokemon Class
	#region Armaldo
	public class Armaldo : Pokemon
	{
		#region Armaldo Builders
		/// <summary>
		/// Armaldo Builder waiting for a Nickname & a Level
		/// </summary>
		public Armaldo(string nickname, int level)
		: base(
				348,
				SpecieArmaldo.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Builder only waiting for a Level
		/// </summary>
		public Armaldo(int level)
		: base(
				348,
				SpecieArmaldo.Instance, // Pokemon Specie
				"Armaldo", level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Armaldo() : base(
			348,
			SpecieArmaldo.Instance, // Pokemon Specie
			Rock.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}