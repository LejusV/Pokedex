using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mamoswine Specie to store common natural stats of all Mamoswines
	#region SpecieMamoswine
	public class SpecieMamoswine : PokemonSpecie
	{
#nullable enable
		private static SpecieMamoswine? _instance = null;
#nullable restore
        public static SpecieMamoswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMamoswine();
                }
                return _instance;
            }
        }

		#region SpecieMamoswine Builder
		public SpecieMamoswine() : base(
			"Mamoswine",
			110, // HPs
			130, 80, // Attack & Defense
			70, 60, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Mamoswine Pokemon Class
	#region Mamoswine
	public class Mamoswine : Pokemon
	{
		#region Mamoswine Builders
		/// <summary>
		/// Mamoswine Builder waiting for a Nickname & a Level
		/// </summary>
		public Mamoswine(string nickname, int level)
		: base(
				473,
				SpecieMamoswine.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Builder only waiting for a Level
		/// </summary>
		public Mamoswine(int level)
		: base(
				473,
				SpecieMamoswine.Instance, // Pokemon Specie
				"Mamoswine", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mamoswine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mamoswine() : base(
			473,
			SpecieMamoswine.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}