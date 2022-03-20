using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ampharos Species to store common natural stats of all Amphaross
	#region AmpharosSpecies
	public class AmpharosSpecies : PokemonSpecies
	{
#nullable enable
		private static AmpharosSpecies? _instance = null;
#nullable restore
        public static AmpharosSpecies Instance => _instance ?? (_instance = new AmpharosSpecies());

		#region AmpharosSpecies Constructor
		public AmpharosSpecies() : base(
			181,
			"Ampharos",
			Electric.Instance,
			1.4,
			61.5,
			new PokemonStats(
				90, // HPs
				75, 85, // Attack & Defense
				115, 90, // Spacial Attack & Defense
				55 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Defense-Curl",
				"Light-Screen",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Cotton-Spore",
				"Protect",
				"Zap-Cannon",
				"Outrage",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Charge",
				"Brick-Break",
				"Secret-Power",
				"Signal-Beam",
				"Shock-Wave",
				"Natural-Gift",
				"Fling",
				"Magnet-Rise",
				"Dragon-Pulse",
				"Power-Gem",
				"Focus-Blast",
				"Giga-Impact",
				"Rock-Climb",
				"Discharge",
				"Captivate",
				"Charge-Beam",
				"Electro-Ball",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Volt-Switch",
				"Bulldoze",
				"Electroweb",
				"Wild-Charge",
				"Cotton-Guard",
				"Ion-Deluge",
				"Confide",
				"Magnetic-Flux",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}