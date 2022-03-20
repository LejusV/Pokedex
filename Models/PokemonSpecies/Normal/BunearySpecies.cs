using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Buneary Species to store common natural stats of all Bunearys
	#region BunearySpecies
	public class BunearySpecies : PokemonSpecies
	{
#nullable enable
		private static BunearySpecies? _instance = null;
#nullable restore
        public static BunearySpecies Instance => _instance ?? (_instance = new BunearySpecies());

		#region BunearySpecies Constructor
		public BunearySpecies() : base(
			427,
			"Buneary",
			Normal.Instance,
			0.4,
			5.5,
			new PokemonStats(
				55, // HPs
				66, 44, // Attack & Defense
				44, 56, // Spacial Attack & Defense
				85 // Speed
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
				"Pound",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Jump-Kick",
				"Headbutt",
				"Ice-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Dizzy-Punch",
				"Splash",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Foresight",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Magic-Coat",
				"Endeavor",
				"Secret-Power",
				"Teeter-Dance",
				"Mud-Sport",
				"Hyper-Voice",
				"Fake-Tears",
				"Cosmic-Power",
				"Sky-Uppercut",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Last-Resort",
				"Drain-Punch",
				"Switcheroo",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Double-Hit",
				"Entrainment",
				"After-You",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}