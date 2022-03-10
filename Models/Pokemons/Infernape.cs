using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Infernape Species to store common natural stats of all Infernapes
	#region SpeciesInfernape
	public class SpeciesInfernape : PokemonSpecies
	{
#nullable enable
		private static SpeciesInfernape? _instance = null;
#nullable restore
        public static SpeciesInfernape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesInfernape();
                }
                return _instance;
            }
        }

		#region SpeciesInfernape Constructor
		public SpeciesInfernape() : base(
			"Infernape",
			1.2,
			55.0,
			76, // HPs
			104, 71, // Attack & Defense
			104, 71, // Special Attack & Defense
			108		
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Blast-Burn",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Fling",
				"Punishment",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Retaliate",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Infernape PokemonInstance Class
	#region Infernape
	public class InfernapeInstance : PokemonInstance
	{
		#region Infernape Constructors
		/// <summary>
		/// Infernape Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public InfernapeInstance(string nickname, int level)
		: base(
				392,
				SpeciesInfernape.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Builder only waiting for a Level
		/// </summary>
		public InfernapeInstance(int level)
		: base(
				392,
				SpeciesInfernape.Instance, // PokemonInstance Species
				"Infernape", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Infernape Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Infernape() : base(
			392,
			SpeciesInfernape.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}