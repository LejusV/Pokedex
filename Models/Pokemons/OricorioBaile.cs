using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oricorio-Baile Specie to store common natural stats of all Oricorio-Bailes
	#region SpecieOricorio-Baile
	public class SpecieOricorioBaile : PokemonSpecie
	{
#nullable enable
		private static SpecieOricorioBaile? _instance = null;
#nullable restore
        public static SpecieOricorioBaile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOricorioBaile();
                }
                return _instance;
            }
        }

		#region SpecieOricorio-Baile Builder
		public SpecieOricorioBaile() : base(
			"Oricorio-Baile",
			75, // HPs
			70, 70, // Attack & Defense
			98, 70, // Special Attack & Defense
			93			
		) {}
		#endregion
	}
	#endregion

	//Oricorio-Baile Pokemon Class
	#region Oricorio-Baile
	public class OricorioBaile : Pokemon
	{
		#region Oricorio-Baile Builders
		/// <summary>
		/// Oricorio-Baile Builder waiting for a Nickname & a Level
		/// </summary>
		public OricorioBaile(string nickname, int level)
		: base(
				741,
				SpecieOricorioBaile.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Builder only waiting for a Level
		/// </summary>
		public OricorioBaile(int level)
		: base(
				741,
				SpecieOricorioBaile.Instance, // Pokemon Specie
				"Oricorio-Baile", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public OricorioBaile() : base(
			741,
			SpecieOricorioBaile.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}