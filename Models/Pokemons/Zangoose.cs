using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zangoose Species to store common natural stats of all Zangooses
	#region SpeciesZangoose
	public class SpeciesZangoose : PokemonSpecies
	{
#nullable enable
		private static SpeciesZangoose? _instance = null;
#nullable restore
        public static SpeciesZangoose Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZangoose();
                }
                return _instance;
            }
        }

		#region SpeciesZangoose Constructor
		public SpeciesZangoose() : base(
			335,
			"Zangoose",
			1.3,
			40.3,
			73, // HPs
			115, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			90		
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
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Razor-Wind",
				"Swords-Dance",
				"Double-Kick",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Disable",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Belly-Drum",
				"Mud-Slap",
				"Icy-Wind",
				"Detect",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Pursuit",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Payback",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Focus-Blast",
				"Shadow-Claw",
				"Rock-Climb",
				"Captivate",
				"Double-Hit",
				"Hone-Claws",
				"Round",
				"Quick-Guard",
				"Incinerate",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Zangoose PokemonInstance Class
	#region Zangoose
	public class ZangooseInstance : PokemonInstance
	{
		#region Zangoose Constructors
		/// <summary>
		/// Zangoose Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZangooseInstance(string nickname, int level)
		: base(
				SpeciesZangoose.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Builder only waiting for a Level
		/// </summary>
		public ZangooseInstance(int level)
		: base(
				SpeciesZangoose.Instance, // PokemonInstance Species
				"Zangoose", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZangooseInstance() : base(
			SpeciesZangoose.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}