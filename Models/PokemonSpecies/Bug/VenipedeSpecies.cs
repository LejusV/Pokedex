using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Venipede Species to store common natural stats of all Venipedes
	#region VenipedeSpecies
	public class VenipedeSpecies : PokemonSpecies
	{
#nullable enable
		private static VenipedeSpecies? _instance = null;
#nullable restore
        public static VenipedeSpecies Instance => _instance ?? (_instance = new VenipedeSpecies());

		#region VenipedeSpecies Constructor
		public VenipedeSpecies() : base(
			543,
			"Venipede",
			Bug.Instance, Poison.Instance,
			0.4,
			5.3,
			new PokemonStats(
				30, // HPs
				45, 59, // Attack & Defense
				30, 39, // Spacial Attack & Defense
				57 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Solar-Beam",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Spikes",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Iron-Defense",
				"Poison-Tail",
				"Gyro-Ball",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Rock-Climb",
				"Bug-Bite",
				"Venoshock",
				"Round",
				"Struggle-Bug",
				"Steamroller",
				"Confide",
				"Venom-Drench",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}