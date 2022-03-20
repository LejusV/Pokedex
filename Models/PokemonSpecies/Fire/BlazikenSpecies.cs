using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Blaziken Species to store common natural stats of all Blazikens
	#region BlazikenSpecies
	public class BlazikenSpecies : PokemonSpecies
	{
#nullable enable
		private static BlazikenSpecies? _instance = null;
#nullable restore
        public static BlazikenSpecies Instance => _instance ?? (_instance = new BlazikenSpecies());

		#region BlazikenSpecies Constructor
		public BlazikenSpecies() : base(
			257,
			"Blaziken",
			Fire.Instance, Fighting.Instance,
			1.9,
			52.0,
			new PokemonStats(
				80, // HPs
				120, 70, // Attack & Defense
				110, 70, // Spacial Attack & Defense
				80 // Speed
			)			
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
}