using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Torchic Specie to store common natural stats of all Torchics
	#region SpecieTorchic
	public class SpecieTorchic : PokemonSpecie
	{
#nullable enable
		private static SpecieTorchic? _instance = null;
#nullable restore
        public static SpecieTorchic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTorchic();
                }
                return _instance;
            }
        }

		#region SpecieTorchic Builder
		public SpecieTorchic() : base(
			"Torchic",
			45, // HPs
			60, 40, // Attack & Defense
			70, 50, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Torchic Pokemon Class
	#region Torchic
	public class Torchic : Pokemon
	{
		#region Torchic Builders
		/// <summary>
		/// Torchic Builder waiting for a Nickname & a Level
		/// </summary>
		public Torchic(string nickname, int level)
		: base(
				255,
				SpecieTorchic.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Builder only waiting for a Level
		/// </summary>
		public Torchic(int level)
		: base(
				255,
				SpecieTorchic.Instance, // Pokemon Specie
				"Torchic", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torchic Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Torchic() : base(
			255,
			SpecieTorchic.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}