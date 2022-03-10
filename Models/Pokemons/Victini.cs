using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Victini Species to store common natural stats of all Victinis
	#region SpeciesVictini
	public class SpeciesVictini : PokemonSpecies
	{
#nullable enable
		private static SpeciesVictini? _instance = null;
#nullable restore
        public static SpeciesVictini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesVictini();
                }
                return _instance;
            }
        }

		#region SpeciesVictini Constructor
		public SpeciesVictini() : base(
			"Victini",
			0.4,
			4.0,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
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
				"Thunder-Punch",
				"Headbutt",
				"Double-Edge",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Fire-Blast",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Brick-Break",
				"Skill-Swap",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"U-Turn",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Flare-Blitz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Stored-Power",
				"Incinerate",
				"Final-Gambit",
				"Inferno",
				"Work-Up",
				"Wild-Charge",
				"Searing-Shot",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Victini PokemonInstance Class
	#region Victini
	public class VictiniInstance : PokemonInstance
	{
		#region Victini Constructors
		/// <summary>
		/// Victini Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public VictiniInstance(string nickname, int level)
		: base(
				494,
				SpeciesVictini.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Builder only waiting for a Level
		/// </summary>
		public VictiniInstance(int level)
		: base(
				494,
				SpeciesVictini.Instance, // PokemonInstance Species
				"Victini", level,
				Psychic.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Victini Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Victini() : base(
			494,
			SpeciesVictini.Instance, // PokemonInstance Species
			Psychic.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}