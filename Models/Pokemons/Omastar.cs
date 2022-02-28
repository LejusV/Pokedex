using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Omastar Specie to store common natural stats of all Omastars
	#region SpecieOmastar
	public class SpecieOmastar : PokemonSpecie
	{
#nullable enable
		private static SpecieOmastar? _instance = null;
#nullable restore
        public static SpecieOmastar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOmastar();
                }
                return _instance;
            }
        }

		#region SpecieOmastar Builder
		public SpecieOmastar() : base(
			"Omastar",
			70, // HPs
			60, 125, // Attack & Defense
			115, 70, // Special Attack & Defense
			55			
		) {}
		#endregion
	}
	#endregion

	//Omastar Pokemon Class
	#region Omastar
	public class Omastar : Pokemon
	{
		#region Omastar Builders
		/// <summary>
		/// Omastar Builder waiting for a Nickname & a Level
		/// </summary>
		public Omastar(string nickname, int level)
		: base(
				139,
				SpecieOmastar.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Builder only waiting for a Level
		/// </summary>
		public Omastar(int level)
		: base(
				139,
				SpecieOmastar.Instance, // Pokemon Specie
				"Omastar", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Omastar() : base(
			139,
			SpecieOmastar.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}