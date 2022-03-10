using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Shelmet Species to store common natural stats of all Shelmets
	#region SpeciesShelmet
	public class SpeciesShelmet : PokemonSpecies
	{
#nullable enable
		private static SpeciesShelmet? _instance = null;
#nullable restore
        public static SpeciesShelmet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesShelmet();
                }
                return _instance;
            }
        }

		#region SpeciesShelmet Constructor
		public SpeciesShelmet() : base(
			"Shelmet",
			0.4,
			7.7,
			50, // HPs
			40, 85, // Attack & Defense
			40, 65, // Special Attack & Defense
			25		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Body-Slam",
				"Double-Edge",
				"Acid",
				"Absorb",
				"Mega-Drain",
				"Toxic",
				"Double-Team",
				"Recover",
				"Bide",
				"Leech-Life",
				"Acid-Armor",
				"Rest",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Spikes",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Facade",
				"Yawn",
				"Secret-Power",
				"Signal-Beam",
				"Feint",
				"Gastro-Acid",
				"Guard-Swap",
				"Toxic-Spikes",
				"Bug-Buzz",
				"Energy-Ball",
				"Bug-Bite",
				"Guard-Split",
				"Venoshock",
				"Round",
				"Final-Gambit",
				"Struggle-Bug",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion

	//Shelmet PokemonInstance Class
	#region Shelmet
	public class ShelmetInstance : PokemonInstance
	{
		#region Shelmet Constructors
		/// <summary>
		/// Shelmet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ShelmetInstance(string nickname, int level)
		: base(
				616,
				SpeciesShelmet.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Builder only waiting for a Level
		/// </summary>
		public ShelmetInstance(int level)
		: base(
				616,
				SpeciesShelmet.Instance, // PokemonInstance Species
				"Shelmet", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelmet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Shelmet() : base(
			616,
			SpeciesShelmet.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}