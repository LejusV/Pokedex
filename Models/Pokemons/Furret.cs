using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Furret Species to store common natural stats of all Furrets
	#region SpeciesFurret
	public class SpeciesFurret : PokemonSpecies
	{
#nullable enable
		private static SpeciesFurret? _instance = null;
#nullable restore
        public static SpeciesFurret Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesFurret();
                }
                return _instance;
            }
        }

		#region SpeciesFurret Constructor
		public SpeciesFurret() : base(
			"Furret",
			1.8,
			32.5,
			85, // HPs
			76, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Trick",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Fling",
				"Me-First",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Coil",
				"Round",
				"Echoed-Voice",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Furret PokemonInstance Class
	#region Furret
	public class FurretInstance : PokemonInstance
	{
		#region Furret Constructors
		/// <summary>
		/// Furret Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public FurretInstance(string nickname, int level)
		: base(
				162,
				SpeciesFurret.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Builder only waiting for a Level
		/// </summary>
		public FurretInstance(int level)
		: base(
				162,
				SpeciesFurret.Instance, // PokemonInstance Species
				"Furret", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Furret() : base(
			162,
			SpeciesFurret.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}