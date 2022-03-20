using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Krookodile Species to store common natural stats of all Krookodiles
	#region KrookodileSpecies
	public class KrookodileSpecies : PokemonSpecies
	{
#nullable enable
		private static KrookodileSpecies? _instance = null;
#nullable restore
        public static KrookodileSpecies Instance => _instance ?? (_instance = new KrookodileSpecies());

		#region KrookodileSpecies Constructor
		public KrookodileSpecies() : base(
			553,
			"Krookodile",
			Ground.Instance, Dark.Instance,
			1.5,
			96.3,
			new PokemonStats(
				95, // HPs
				117, 80, // Attack & Defense
				65, 70, // Spacial Attack & Defense
				92 // Speed
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
				"Cut",
				"Sand-Attack",
				"Leer",
				"Bite",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Payback",
				"Assurance",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Smack-Down",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Dragon-Tail",
				"Snarl",
				"Confide",
				"Power-Up-Punch",
				"Power-Trip",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}