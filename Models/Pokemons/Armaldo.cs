using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Armaldo Species to store common natural stats of all Armaldos
	#region SpeciesArmaldo
	public class SpeciesArmaldo : PokemonSpecies
	{
#nullable enable
		private static SpeciesArmaldo? _instance = null;
#nullable restore
        public static SpeciesArmaldo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArmaldo();
                }
                return _instance;
            }
        }

		#region SpeciesArmaldo Constructor
		public SpeciesArmaldo() : base(
			348,
			"Armaldo",
			1.5,
			68.2,
			75, // HPs
			125, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
			45		
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Water-Gun",
				"Hyper-Beam",
				"Low-Kick",
				"Seismic-Toss",
				"Strength",
				"String-Shot",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Mud-Sport",
				"Crush-Claw",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Rock-Polish",
				"Aqua-Tail",
				"X-Scissor",
				"Earth-Power",
				"Giga-Impact",
				"Flash-Cannon",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Armaldo PokemonInstance Class
	#region Armaldo
	public class ArmaldoInstance : PokemonInstance
	{
		#region Armaldo Constructors
		/// <summary>
		/// Armaldo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArmaldoInstance(string nickname, int level)
		: base(
				SpeciesArmaldo.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Builder only waiting for a Level
		/// </summary>
		public ArmaldoInstance(int level)
		: base(
				SpeciesArmaldo.Instance, // PokemonInstance Species
				"Armaldo", level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Armaldo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArmaldoInstance() : base(
			SpeciesArmaldo.Instance, // PokemonInstance Species
			Rock.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}