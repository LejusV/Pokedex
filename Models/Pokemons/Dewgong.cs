using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dewgong Specie to store common natural stats of all Dewgongs
	#region SpecieDewgong
	public class SpecieDewgong : PokemonSpecie
	{
#nullable enable
		private static SpecieDewgong? _instance = null;
#nullable restore
        public static SpecieDewgong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewgong();
                }
                return _instance;
            }
        }

		#region SpecieDewgong Builder
		public SpecieDewgong() : base(
			"Dewgong",
			90, // HPs
			70, 80, // Attack & Defense
			70, 95, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Dewgong Pokemon Class
	#region Dewgong
	public class Dewgong : Pokemon
	{
		#region Dewgong Builders
		/// <summary>
		/// Dewgong Builder waiting for a Nickname & a Level
		/// </summary>
		public Dewgong(string nickname, int level)
		: base(
				87,
				SpecieDewgong.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Builder only waiting for a Level
		/// </summary>
		public Dewgong(int level)
		: base(
				87,
				SpecieDewgong.Instance, // Pokemon Specie
				"Dewgong", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Dewgong() : base(
			87,
			SpecieDewgong.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
		#endregion
	}
	#endregion
}