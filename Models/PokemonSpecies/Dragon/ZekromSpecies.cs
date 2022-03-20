using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zekrom Species to store common natural stats of all Zekroms
	#region ZekromSpecies
	public class ZekromSpecies : PokemonSpecies
	{
#nullable enable
		private static ZekromSpecies? _instance = null;
#nullable restore
        public static ZekromSpecies Instance => _instance ?? (_instance = new ZekromSpecies());

		#region ZekromSpecies Constructor
		public ZekromSpecies() : base(
			644,
			"Zekrom",
			Dragon.Instance, Electric.Instance,
			2.9,
			345.0,
			new PokemonStats(
				100, // HPs
				150, 120, // Attack & Defense
				120, 100, // Spacial Attack & Defense
				90 // Speed
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
				"Thunder-Punch",
				"Cut",
				"Fly",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Imprison",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Dragon-Claw",
				"Shock-Wave",
				"Roost",
				"Tailwind",
				"Payback",
				"Fling",
				"Magnet-Rise",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Draco-Meteor",
				"Stone-Edge",
				"Charge-Beam",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Dragon-Tail",
				"Wild-Charge",
				"Bolt-Strike",
				"Fusion-Bolt",
				"Noble-Roar",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}