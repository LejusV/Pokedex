using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chimchar Specie to store common natural stats of all Chimchars
	#region SpecieChimchar
	public class SpecieChimchar : PokemonSpecie
	{
#nullable enable
		private static SpecieChimchar? _instance = null;
#nullable restore
        public static SpecieChimchar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChimchar();
                }
                return _instance;
            }
        }

		#region SpecieChimchar Builder
		public SpecieChimchar() : base(
			"Chimchar",
			0.5,
			6.2,
			44, // HPs
			58, 44, // Attack & Defense
			58, 44, // Special Attack & Defense
			61		
		)
		{}
		#endregion
	}
	#endregion

	//Chimchar Pokemon Class
	#region Chimchar
	public class Chimchar : Pokemon
	{
		#region Chimchar Builders
		/// <summary>
		/// Chimchar Builder waiting for a Nickname & a Level
		/// </summary>
		public Chimchar(string nickname, int level)
		: base(
				390,
				SpecieChimchar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Builder only waiting for a Level
		/// </summary>
		public Chimchar(int level)
		: base(
				390,
				SpecieChimchar.Instance, // Pokemon Specie
				"Chimchar", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimchar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chimchar() : base(
			390,
			SpecieChimchar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}