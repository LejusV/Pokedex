using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Deoxys-Normal Specie to store common natural stats of all Deoxys-Normals
	#region SpecieDeoxys-Normal
	public class SpecieDeoxysNormal : PokemonSpecie
	{
#nullable enable
		private static SpecieDeoxysNormal? _instance = null;
#nullable restore
        public static SpecieDeoxysNormal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeoxysNormal();
                }
                return _instance;
            }
        }

		#region SpecieDeoxys-Normal Builder
		public SpecieDeoxysNormal() : base(
			"Deoxys-Normal",
			50, // HPs
			150, 50, // Attack & Defense
			150, 50, // Special Attack & Defense
			150			
		) {}
		#endregion
	}
	#endregion

	//Deoxys-Normal Pokemon Class
	#region Deoxys-Normal
	public class DeoxysNormal : Pokemon
	{
		#region Deoxys-Normal Builders
		/// <summary>
		/// Deoxys-Normal Builder waiting for a Nickname & a Level
		/// </summary>
		public DeoxysNormal(string nickname, int level)
		: base(
				386,
				SpecieDeoxysNormal.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Builder only waiting for a Level
		/// </summary>
		public DeoxysNormal(int level)
		: base(
				386,
				SpecieDeoxysNormal.Instance, // Pokemon Specie
				"Deoxys-Normal", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public DeoxysNormal() : base(
			386,
			SpecieDeoxysNormal.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}