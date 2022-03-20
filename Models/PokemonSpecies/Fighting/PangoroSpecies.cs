using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pangoro Species to store common natural stats of all Pangoros
	#region PangoroSpecies
	public class PangoroSpecies : PokemonSpecies
	{
#nullable enable
		private static PangoroSpecies? _instance = null;
#nullable restore
        public static PangoroSpecies Instance => _instance ?? (_instance = new PangoroSpecies());

		#region PangoroSpecies Constructor
		public PangoroSpecies() : base(
			675,
			"Pangoro",
			Fighting.Instance, Dark.Instance,
			2.1,
			136.0,
			new PokemonStats(
				95, // HPs
				124, 78, // Attack & Defense
				69, 71, // Spacial Attack & Defense
				58 // Speed
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
				"Karate-Chop",
				"Comet-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Body-Slam",
				"Leer",
				"Roar",
				"Surf",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Vital-Throw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Arm-Thrust",
				"Hyper-Voice",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Payback",
				"Embargo",
				"Fling",
				"Poison-Jab",
				"Dark-Pulse",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Bullet-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Circle-Throw",
				"Quash",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Snarl",
				"Parting-Shot",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}