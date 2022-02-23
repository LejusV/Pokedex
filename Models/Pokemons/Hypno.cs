using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hypno Specie to store common natural stats of every {'abilities': ['insomnia', 'forewarn', 'inner-focus'], 'base_experience': 169, 'height': 16, 'id': 97, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'disable', 'psybeam', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'meditate', 'rage', 'teleport', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'dream-eater', 'poison-gas', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'signal-beam', 'calm-mind', 'wake-up-slap', 'natural-gift', 'fling', 'drain-punch', 'focus-blast', 'switcheroo', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'psyshock', 'telekinesis', 'magic-room', 'synchronoise', 'low-sweep', 'foul-play', 'round', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'hypno', 'stats': {'hp': 85, 'attack': 73, 'defense': 70, 'special-attack': 73, 'special-defense': 115, 'speed': 67}, 'types': ['psychic'], 'weight': 756, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'スリーパー', 'roomaji': 'Sleeper', 'ko': '슬리퍼', 'zh-Hant': '引夢貘人', 'fr': 'Hypnomade', 'de': 'Hypno', 'es': 'Hypno', 'it': 'Hypno', 'en': 'Hypno', 'ja': 'スリーパー', 'zh-Hans': '引梦貘人'}, 'genera': {'ja-Hrkt': 'さいみんポケモン', 'ko': '최면포켓몬', 'zh-Hant': '催眠寶可夢', 'fr': 'Pokémon Hypnose', 'de': 'Hypnose', 'es': 'Pokémon Hipnosis', 'it': 'Pokémon Ipnosi', 'en': 'Hypnosis Pokémon', 'ja': 'さいみんポケモン', 'zh-Hans': '催眠宝可梦'}}
	public class SpecieHypno : PokemonSpecie
	{
#nullable enable
		private static SpecieHypno? _instance = null;
#nullable restore
        public static SpecieHypno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHypno();
                }
                return _instance;
            }
        }

		public SpecieHypno() : base(
			"Hypno",
			85, // HPs
			73, 70, // Attack & Defense
			73, 115, // Special Attack & Defense
			67			
		) {}
	}


	//Hypno Pokemon Class
	public class Hypno : Pokemon
	{

		public Hypno(string nickname, int level) : base(
			97,
			SpecieHypno.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Hypno() : base(
			97,
			SpecieHypno.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}