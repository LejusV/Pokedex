using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Feraligatr Specie to store common natural stats of all Feraligatrs
	#region SpecieFeraligatr
	public class SpecieFeraligatr : PokemonSpecie
	{
#nullable enable
		private static SpecieFeraligatr? _instance = null;
#nullable restore
        public static SpecieFeraligatr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFeraligatr();
                }
                return _instance;
            }
        }

		#region SpecieFeraligatr Builder
		public SpecieFeraligatr() : base(
			"Feraligatr",
			85, // HPs
			105, 100, // Attack & Defense
			79, 83, // Special Attack & Defense
			78			
		) {}
		#endregion
	}
	#endregion

	//Feraligatr Pokemon Class
	#region Feraligatr
	public class Feraligatr : Pokemon
	{
		#region Feraligatr Builders
		/// <summary>
		/// Feraligatr Builder waiting for a Nickname & a Level
		/// </summary>
		public Feraligatr(string nickname, int level)
		: base(
				160,
				SpecieFeraligatr.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Builder only waiting for a Level
		/// </summary>
		public Feraligatr(int level)
		: base(
				160,
				SpecieFeraligatr.Instance, // Pokemon Specie
				"Feraligatr", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feraligatr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Feraligatr() : base(
			160,
			SpecieFeraligatr.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}