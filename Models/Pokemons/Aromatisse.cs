using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aromatisse Specie to store common natural stats of all Aromatisses
	#region SpecieAromatisse
	public class SpecieAromatisse : PokemonSpecie
	{
#nullable enable
		private static SpecieAromatisse? _instance = null;
#nullable restore
        public static SpecieAromatisse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAromatisse();
                }
                return _instance;
            }
        }

		#region SpecieAromatisse Builder
		public SpecieAromatisse() : base(
			"Aromatisse",
			101, // HPs
			72, 72, // Attack & Defense
			99, 89, // Special Attack & Defense
			29			
		) {}
		#endregion
	}
	#endregion

	//Aromatisse Pokemon Class
	#region Aromatisse
	public class Aromatisse : Pokemon
	{
		#region Aromatisse Builders
		/// <summary>
		/// Aromatisse Builder waiting for a Nickname & a Level
		/// </summary>
		public Aromatisse(string nickname, int level)
		: base(
				683,
				SpecieAromatisse.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Builder only waiting for a Level
		/// </summary>
		public Aromatisse(int level)
		: base(
				683,
				SpecieAromatisse.Instance, // Pokemon Specie
				"Aromatisse", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Aromatisse() : base(
			683,
			SpecieAromatisse.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}