using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blaziken Species to store common natural stats of all Blazikens
	#region SpeciesBlaziken
	public class SpeciesBlaziken : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlaziken? _instance = null;
#nullable restore
        public static SpeciesBlaziken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlaziken();
                }
                return _instance;
            }
        }

		#region SpeciesBlaziken Constructor
		public SpeciesBlaziken() : base(
			"Blaziken",
			1.9,
			52.0,
			80, // HPs
			120, 70, // Attack & Defense
			110, 70, // Special Attack & Defense
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Peck",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Blaze-Kick",
				"Blast-Burn",
				"Overheat",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Bulk-Up",
				"Bounce",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Brave-Bird",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Acrobatics",
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

	//Blaziken PokemonInstance Class
	#region Blaziken
	public class BlazikenInstance : PokemonInstance
	{
		#region Blaziken Constructors
		/// <summary>
		/// Blaziken Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlazikenInstance(string nickname, int level)
		: base(
				257,
				SpeciesBlaziken.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Builder only waiting for a Level
		/// </summary>
		public BlazikenInstance(int level)
		: base(
				257,
				SpeciesBlaziken.Instance, // PokemonInstance Species
				"Blaziken", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blaziken Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Blaziken() : base(
			257,
			SpeciesBlaziken.Instance, // PokemonInstance Species
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}