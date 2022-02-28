using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gossifleur Specie to store common natural stats of all Gossifleurs
	#region SpecieGossifleur
	public class SpecieGossifleur : PokemonSpecie
	{
#nullable enable
		private static SpecieGossifleur? _instance = null;
#nullable restore
        public static SpecieGossifleur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGossifleur();
                }
                return _instance;
            }
        }

		#region SpecieGossifleur Builder
		public SpecieGossifleur() : base(
			"Gossifleur",
			40, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			10			
		) {}
		#endregion
	}
	#endregion

	//Gossifleur Pokemon Class
	#region Gossifleur
	public class Gossifleur : Pokemon
	{
		#region Gossifleur Builders
		/// <summary>
		/// Gossifleur Builder waiting for a Nickname & a Level
		/// </summary>
		public Gossifleur(string nickname, int level)
		: base(
				829,
				SpecieGossifleur.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Builder only waiting for a Level
		/// </summary>
		public Gossifleur(int level)
		: base(
				829,
				SpecieGossifleur.Instance, // Pokemon Specie
				"Gossifleur", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Gossifleur() : base(
			829,
			SpecieGossifleur.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}