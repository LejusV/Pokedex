using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Absol Species to store common natural stats of all Absols
	#region SpeciesAbsol
	public class SpeciesAbsol : PokemonSpecies
	{
#nullable enable
		private static SpeciesAbsol? _instance = null;
#nullable restore
        public static SpeciesAbsol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAbsol();
                }
                return _instance;
            }
        }

		#region SpeciesAbsol Constructor
		public SpeciesAbsol() : base(
			"Absol",
			1.2,
			47.0,
			65, // HPs
			130, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			75		
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
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Hail",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Magic-Coat",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bounce",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Assurance",
				"Me-First",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
				"Night-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Stone-Edge",
				"Captivate",
				"Charge-Beam",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Echoed-Voice",
				"Hex",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Absol PokemonInstance Class
	#region Absol
	public class AbsolInstance : PokemonInstance
	{
		#region Absol Constructors
		/// <summary>
		/// Absol Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AbsolInstance(string nickname, int level)
		: base(
				359,
				SpeciesAbsol.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Builder only waiting for a Level
		/// </summary>
		public AbsolInstance(int level)
		: base(
				359,
				SpeciesAbsol.Instance, // PokemonInstance Species
				"Absol", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Absol Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Absol() : base(
			359,
			SpeciesAbsol.Instance, // PokemonInstance Species
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}