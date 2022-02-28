using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marowak Specie to store common natural stats of all Marowaks
	#region SpecieMarowak
	public class SpecieMarowak : PokemonSpecie
	{
#nullable enable
		private static SpecieMarowak? _instance = null;
#nullable restore
        public static SpecieMarowak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarowak();
                }
                return _instance;
            }
        }

		#region SpecieMarowak Builder
		public SpecieMarowak() : base(
			"Marowak",
			60, // HPs
			80, 110, // Attack & Defense
			50, 80, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Marowak Pokemon Class
	#region Marowak
	public class Marowak : Pokemon
	{
		#region Marowak Builders
		/// <summary>
		/// Marowak Builder waiting for a Nickname & a Level
		/// </summary>
		public Marowak(string nickname, int level)
		: base(
				105,
				SpecieMarowak.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Builder only waiting for a Level
		/// </summary>
		public Marowak(int level)
		: base(
				105,
				SpecieMarowak.Instance, // Pokemon Specie
				"Marowak", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marowak Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Marowak() : base(
			105,
			SpecieMarowak.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}