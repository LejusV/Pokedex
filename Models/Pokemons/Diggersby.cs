using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Diggersby Species to store common natural stats of all Diggersbys
	#region SpeciesDiggersby
	public class SpeciesDiggersby : PokemonSpecies
	{
#nullable enable
		private static SpeciesDiggersby? _instance = null;
#nullable restore
        public static SpeciesDiggersby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDiggersby();
                }
                return _instance;
            }
        }

		#region SpeciesDiggersby Constructor
		public SpeciesDiggersby() : base(
			"Diggersby",
			1.0,
			42.4,
			85, // HPs
			56, 77, // Attack & Defense
			50, 77, // Special Attack & Defense
			78		
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
				"Double-Slap",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Tackle",
				"Take-Down",
				"Leer",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Superpower",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Odor-Sleuth",
				"Rock-Tomb",
				"Bulk-Up",
				"Bounce",
				"Mud-Shot",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Last-Resort",
				"Earth-Power",
				"Giga-Impact",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Smack-Down",
				"Foul-Play",
				"Round",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Rototiller",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Diggersby PokemonInstance Class
	#region Diggersby
	public class DiggersbyInstance : PokemonInstance
	{
		#region Diggersby Constructors
		/// <summary>
		/// Diggersby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DiggersbyInstance(string nickname, int level)
		: base(
				660,
				SpeciesDiggersby.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Builder only waiting for a Level
		/// </summary>
		public DiggersbyInstance(int level)
		: base(
				660,
				SpeciesDiggersby.Instance, // PokemonInstance Species
				"Diggersby", level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Diggersby() : base(
			660,
			SpeciesDiggersby.Instance, // PokemonInstance Species
			Normal.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}