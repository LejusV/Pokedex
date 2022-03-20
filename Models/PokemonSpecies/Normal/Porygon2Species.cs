using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Porygon2 Species to store common natural stats of all Porygon2s
	#region Porygon2Species
	public class Porygon2Species : PokemonSpecies
	{
#nullable enable
		private static Porygon2Species? _instance = null;
#nullable restore
        public static Porygon2Species Instance => _instance ?? (_instance = new Porygon2Species());

		#region Porygon2Species Constructor
		public Porygon2Species() : base(
			233,
			"Porygon2",
			Normal.Instance,
			0.6,
			32.5,
			new PokemonStats(
				85, // HPs
				80, 90, // Attack & Defense
				105, 95, // Spacial Attack & Defense
				60 // Speed
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
				"Tackle",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Conversion",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Conversion-2",
				"Protect",
				"Zap-Cannon",
				"Icy-Wind",
				"Lock-On",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Secret-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Last-Resort",
				"Magnet-Rise",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Discharge",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Foul-Play",
				"Round",
				"Electroweb",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}