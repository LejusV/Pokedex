using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Riolu Specie to store common natural stats of all Riolus
	#region SpecieRiolu
	public class SpecieRiolu : PokemonSpecie
	{
#nullable enable
		private static SpecieRiolu? _instance = null;
#nullable restore
        public static SpecieRiolu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRiolu();
                }
                return _instance;
            }
        }

		#region SpecieRiolu Builder
		public SpecieRiolu() : base(
			"Riolu",
			40, // HPs
			70, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Riolu Pokemon Class
	#region Riolu
	public class Riolu : Pokemon
	{
		#region Riolu Builders
		/// <summary>
		/// Riolu Builder waiting for a Nickname & a Level
		/// </summary>
		public Riolu(string nickname, int level)
		: base(
				447,
				SpecieRiolu.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Builder only waiting for a Level
		/// </summary>
		public Riolu(int level)
		: base(
				447,
				SpecieRiolu.Instance, // Pokemon Specie
				"Riolu", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Riolu() : base(
			447,
			SpecieRiolu.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}