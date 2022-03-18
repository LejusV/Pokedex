using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gardevoir Species to store common natural stats of all Gardevoirs
	#region SpeciesGardevoir
	public class SpeciesGardevoir : PokemonSpecies
	{
#nullable enable
		private static SpeciesGardevoir? _instance = null;
#nullable restore
        public static SpeciesGardevoir Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGardevoir();
                }
                return _instance;
            }
        }

		#region SpeciesGardevoir Constructor
		public SpeciesGardevoir() : base(
			282,
			"Gardevoir",
			1.6,
			48.4,
			68, // HPs
			65, 65, // Attack & Defense
			125, 115, // Special Attack & Defense
			80		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Teleport",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Magical-Leaf",
				"Calm-Mind",
				"Shock-Wave",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Ally-Switch",
				"Heal-Pulse",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Gardevoir PokemonInstance Class
	#region Gardevoir
	public class GardevoirInstance : PokemonInstance
	{
		#region Gardevoir Constructors
		/// <summary>
		/// Gardevoir Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GardevoirInstance(string nickname, int level)
		: base(
				SpeciesGardevoir.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Builder only waiting for a Level
		/// </summary>
		public GardevoirInstance(int level)
		: base(
				SpeciesGardevoir.Instance, // PokemonInstance Species
				"Gardevoir", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gardevoir Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GardevoirInstance() : base(
			SpeciesGardevoir.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}