using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxicroak Specie to store common natural stats of all Toxicroaks
	#region SpecieToxicroak
	public class SpecieToxicroak : PokemonSpecie
	{
#nullable enable
		private static SpecieToxicroak? _instance = null;
#nullable restore
        public static SpecieToxicroak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxicroak();
                }
                return _instance;
            }
        }

		#region SpecieToxicroak Builder
		public SpecieToxicroak() : base(
			"Toxicroak",
			83, // HPs
			106, 65, // Attack & Defense
			86, 65, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Toxicroak Pokemon Class
	#region Toxicroak
	public class Toxicroak : Pokemon
	{
		#region Toxicroak Builders
		/// <summary>
		/// Toxicroak Builder waiting for a Nickname & a Level
		/// </summary>
		public Toxicroak(string nickname, int level)
		: base(
				454,
				SpecieToxicroak.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Builder only waiting for a Level
		/// </summary>
		public Toxicroak(int level)
		: base(
				454,
				SpecieToxicroak.Instance, // Pokemon Specie
				"Toxicroak", level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxicroak Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Toxicroak() : base(
			454,
			SpecieToxicroak.Instance, // Pokemon Specie
			Poison.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}